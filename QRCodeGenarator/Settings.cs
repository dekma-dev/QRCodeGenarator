using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System.Security.AccessControl;

namespace QRCodeGenarator
{
    public partial class Settings : MaterialForm
    {
        public Settings(bool theme)
        {
            InitializeComponent();
            this.Initialize(theme);
        }

        public void SQLConnect(string server = "127.0.0.1", string port = "5432", string db = "test1", string login = "postgres", string password = "")
        {
            NpgsqlConnection conn = new NpgsqlConnection($"Server={server};Port={port};Database={db}; User Id = {login}; Password={password}");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = $"SELECT * FROM {tableTB.Text}";
            NpgsqlDataReader reader = command.ExecuteReader();

            command.Dispose();
            conn.Close();
        }

        private void Settings_Load(object sender, EventArgs e) { }

        private void applyBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (hostTB.Text.Length > 0 && portTB.Text.Length > 0 && dbTB.Text.Length > 0 && loginTB.Text.Length > 0)
                {
                    SQLConnect(hostTB.Text, portTB.Text, dbTB.Text, loginTB.Text, passTB.Text);
                }
                else throw new Exception("Lost arguments, check an input boxes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// re-initialize cuz MaterialSkin2 lib breaks all form styles
        /// </summary>
        /// <param name="theme">theme mod</param>
        private void Initialize(bool theme)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            if (!theme)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Grey900, Primary.Yellow900, Accent.Red700, TextShade.WHITE);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Grey900, Primary.Yellow900, Accent.Yellow700, TextShade.WHITE);
            }

            this.hostTB.Size = new System.Drawing.Size(400, 48);
            this.portTB.Size = new System.Drawing.Size(400, 48);
            this.dbTB.Size = new System.Drawing.Size(400, 48);
            this.loginTB.Size = new System.Drawing.Size(400, 48);
            this.passTB.Size = new System.Drawing.Size(400, 48);
            this.tableTB.Size = new System.Drawing.Size(400, 48);

            this.hostTB.Location = new System.Drawing.Point(143, 108);
            this.portTB.Location = new System.Drawing.Point(143, 169);
            this.dbTB.Location = new System.Drawing.Point(143, 230);
            this.loginTB.Location = new System.Drawing.Point(143, 291);
            this.passTB.Location = new System.Drawing.Point(143, 353);
            this.tableTB.Location = new System.Drawing.Point(143, 415);
        }
    }
}
