using QRCoder;
using System.Drawing.Printing;
using MaterialSkin.Controls;
using MaterialSkin;

namespace QRCodeGenarator
{
    public partial class Main : MaterialForm
    {
        private Thread? settingsThread;
        public static string? logoFilePath;
        public static Size baseQRSize = new Size(76, 76);
        public static int fontSize = 14;
        public static int verticalIndent = 77;
        public static int horizontalIndent = 0;
        public static Bitmap original = new Bitmap("C:\\Работа\\QRCodeGenerator\\white.png");
        public static bool isReadyToPrint = false;
        public static bool isDarkTheme = false;

        public Main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            ///<summary>
            ///Установка цветовой схемы приложения
            ///</summary>
            ///<param name="primary">цвет navbar</param>
            ///<param name="darkPrimary">цвет верхнней панели самого окна</param>
            ///<param name="lightPrimary">хз</param>
            ///<param name="lightPrimary">цвет хайлайтов</param>
            ///<param name="lightPrimary">цвет текста на панелях</param>
            themeSwitch_CheckedChanged(this, EventArgs.Empty);

            this.KeyPreview = true;
            materialListLogos.LargeImageList = imageList1;
            listView1.LargeImageList = imageList1;
            plusButton.Text = char.ConvertFromUtf32(0x2191);
            minusButton.Text = char.ConvertFromUtf32(0x2193);
            themeIconLabel.Text = char.ConvertFromUtf32(0x1F319);

            List<string> list = new List<string>()
            {
                "BETAR",
                "VEGA",
                "anything",
                "blablabla",
                "СГВ",
                "СХВ",
                "ХВ"
            };

            foreach (var data in list)
            {
                MaterialListBoxItem singleItem = new MaterialListBoxItem();
                singleItem.Text = data;
                listTitles.Items.Add(singleItem);
            }

            string[] logos = Directory.GetFiles("C:\\Работа\\QRCodeGenerator", "*jpg");
            materialListLogos.View = View.LargeIcon;
            materialListLogos.GridLines = true;
            materialListLogos.FullRowSelect = true;
            materialListLogos.Columns.Add("Из папки C:\\Работа\\QRCodeGenerator", materialListLogos.Width, HorizontalAlignment.Left);

            for (int index = 0; index < logos.Length; index++)
            {
                imageList1.Images.Add(Image.FromFile(logos[index]));

                ListViewItem item = new ListViewItem();
                item.Text = logos[index][26..^4];
                item.ImageIndex = index;

                listView1.Items.AddRange(new ListViewItem[] { item });
            }
            serialNumberTextBox.SelectAll();
        }

        private async void serialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (serialNumberTextBox.Text.Length == 8)
            {
                serialNumberTextBox.Enabled = false;
                await Task.Delay(5000);
                valueTextBox_TextChanged(this, EventArgs.Empty);
            }
        }

        private async void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            valueTextBox.Enabled = true;
            valueTextBox.SelectAll();
            await Task.Delay(3500);
            valueTextBox.Enabled = false;
            QRGeneratorButton_Click(this, EventArgs.Empty);
        }

        private void QRGeneratorButton_Click(object sender, EventArgs e)
        {
            if (serialNumberTextBox.Text == "" || valueTextBox.Text == "")
            {
                MessageBox.Show("Заполните поля ввода прежде, чем генерировать QR-код");
                serialNumberTextBox.Text = "";
                serialNumberTextBox.Enabled = true;
                serialNumberTextBox.SelectAll();
            }
            else
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode("{\n\tkey: " + serialNumberTextBox.Text + "\n\n" + "\tvalue: " + valueTextBox.Text + "\n}", QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                pictureBoxQR.Image = qrCode.GetGraphic(3);

                pictureBoxBarCode.Height = pictureBoxQR.Height;
                pictureBoxBarCode.Location = new Point(pictureBoxQR.Location.X + pictureBoxQR.Width, pictureBoxQR.Location.Y); //here
                pictureBoxBarCode.Invalidate();

                baseQRSize = pictureBoxQR.Size;

                chosePrinter_Click(this, EventArgs.Empty);
            }
        }
        private async void chosePrinter_Click(object sender, EventArgs e)
        {
            if (!isReadyToPrint && !setNothingButton.Checked)
            {
                MessageBox.Show("Вставьте логотип или надпись");
            }
            else if (pictureBoxQR.Image == null)
            {
                MessageBox.Show("Сгенерируйте QR-код");
            }
            else
            {
                PrintDocument printer = new PrintDocument();
                printer.PrintPage += PrintPageHandler;
                PrintDialog dialogWindow = new PrintDialog();
                dialogWindow.Document = printer;

                if (dialogWindow.ShowDialog() == DialogResult.OK)
                    dialogWindow.Document.Print();
            }

            await Task.Delay(2000);
            serialNumberTextBox.Text = "";
            valueTextBox.Text = "";
            serialNumberTextBox.Enabled = true;
            serialNumberTextBox.SelectAll();
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(pictureBoxQR.Image, 0, 0, 76, 76);
            if (pictureBoxBarCode.Image != null) graphics.DrawImage(pictureBoxBarCode.Image, 76, 0, 36, 76);
        }

        private void setLogoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (setLogoButton.Checked)
            {
                materialListLogos.Visible = true;
                listView1.Visible = true;
                setSignButton.Checked = false;
                setNothingButton.Checked = false;
                listTitles.Visible = false;
                plusButton.Visible = false;
                minusButton.Visible = false;
                verticalSlider.Visible = false;
                horizontalSlider.Visible = false;

                if (logoFilePath == null) pictureBoxBarCode.Image = (System.Drawing.Image)(new Bitmap(original, new Size(38, 76)));

                serialNumberTextBox.SelectAll();
            }
        }

        private void setSignButton_CheckedChanged(object sender, EventArgs e)
        {
            if (setSignButton.Checked)
            {
                listTitles.Visible = true;
                plusButton.Visible = true;
                verticalSlider.Visible = true;
                horizontalSlider.Visible = true;
                minusButton.Visible = true;
                setLogoButton.Checked = false;
                setNothingButton.Checked = false;
                materialListLogos.Visible = false;
                listView1.Visible = false;

                if (logoFilePath == null) pictureBoxBarCode.Image = (System.Drawing.Image)(new Bitmap(original, new Size(38, 76)));

                serialNumberTextBox.SelectAll();
            }
        }

        private void setNothingButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (setNothingButton.Checked)
            {
                setLogoButton.Checked = false;
                setSignButton.Checked = false;
                materialListLogos.Visible = false;
                listView1.Visible = false;
                listTitles.Visible = false;
                plusButton.Visible = false;
                minusButton.Visible = false;
                verticalSlider.Visible = false;
                horizontalSlider.Visible = false;

                pictureBoxBarCode.Image = null;
                if (logoFilePath != null) pictureBoxBarCode.Image = null;

                serialNumberTextBox.SelectAll();
            }
        }

        private void listLogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.SelectedItems) //foreach (ListViewItem itm in materialListLogos.SelectedItems)
            {
                int imgIndex = itm.ImageIndex;
                if (imgIndex >= 0 && imgIndex < this.imageList1.Images.Count)
                {
                    pictureBoxBarCode.Image = this.imageList1.Images[imgIndex];
                    pictureBoxBarCode.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    isReadyToPrint = true;
                }
            }

            serialNumberTextBox.SelectAll();
        }

        private void plusButton_Click_1(object sender, EventArgs e)
        {
            fontSize++;
            listTitles_SelectedIndexChanged(this, null);
        }

        private void minusButton_Click_1(object sender, EventArgs e)
        {
            fontSize--;
            listTitles_SelectedIndexChanged(this, null);
        }

        private void slider_Click(object sender, EventArgs e)
        {
            verticalIndent = 77 - verticalSlider.Value;
            listTitles_SelectedIndexChanged(this, null);
        }

        private void horizontalSlider_Click(object sender, EventArgs e)
        {
            horizontalIndent = horizontalSlider.Value;
            listTitles_SelectedIndexChanged(this, null);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J && e.Control)
            {
                settingsThread = new Thread(new ThreadStart(Settings));
                settingsThread.Start();
            }

        }

        private void Settings()
        {
            this.Invoke((Action)(() =>
            {
                Settings window = new Settings(isDarkTheme);
                window.ShowDialog();
            }));
        }

        public void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            if (themeSwitch.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red900, Primary.Grey900, Primary.Yellow900, Accent.Red700, TextShade.WHITE);
                listView1.BackColor = Color.White;
                isDarkTheme = false;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow700, Primary.Grey900, Primary.Yellow900, Accent.Yellow700, TextShade.WHITE);
                listView1.BackColor = ColorTranslator.FromHtml("#494a4a"); //#494a4a
                isDarkTheme = true;
            }

        }

        private void listTitles_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (listTitles.SelectedItem != null)
            {
                string? text = listTitles.SelectedItem.Text;

                pictureBoxBarCode.Image = (System.Drawing.Image)(new Bitmap(original, new Size(38, 76)));
                System.Drawing.Font font = new System.Drawing.Font("Rockwell", fontSize);
                Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

                using (Graphics graphics = Graphics.FromImage(pictureBoxBarCode.Image))
                {
                    graphics.TranslateTransform(horizontalIndent, verticalIndent);
                    graphics.RotateTransform(-90);
                    graphics.DrawString(text, font, brush, 0, 0);
                    graphics.Dispose();
                }

                isReadyToPrint = true;
            }

            serialNumberTextBox.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void pictureBoxQR_Click(object sender, EventArgs e) { }
        private void pictureBoxGetBarCode_Paint(object sender, PaintEventArgs e) { }
    }
}