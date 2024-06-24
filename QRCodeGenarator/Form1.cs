using QRCoder;
using System;
using System.Drawing.Printing;
using System.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QRCodeGenarator
{
    public partial class Form1 : Form
    {
        public static string? logoFilePath;
        public static Size baseQRSize = new Size(76, 76);
        public static int fontSize = 14;
        public static Bitmap original = new Bitmap("C:\\Работа\\QRCodeGenerator\\white.png");
        public static bool isReadyToPrint = false;

        public Form1()
        {
            InitializeComponent();
            listLogos.LargeImageList = imageList1;
            plusFont.Text = char.ConvertFromUtf32(0x2191);
            minusFont.Text = char.ConvertFromUtf32(0x2193);

            listTitle.Items.Add("VEGA");
            listTitle.Items.Add("BETAR");
            listTitle.Items.Add("anything");
            listTitle.Items.Add("BM-FI");

            string[] logos = Directory.GetFiles("C:\\Работа\\QRCodeGenerator", "*jpg");
            for (int index = 0; index < logos.Length; index++)
            {
                imageList1.Images.Add(Image.FromFile(logos[index]));

                ListViewItem item = new ListViewItem();
                item.Text = logos[index].Substring(26);
                item.ImageIndex = index;

                listLogos.Items.Add(item);
            }
        }

        private void keyBarCode_TextChanged(object sender, EventArgs e)
        {
            if (keyBarCode.Text.Length == 8)
            {
                valueBarCode_TextChanged(this, EventArgs.Empty);
            }
        }

        private async void valueBarCode_TextChanged(object sender, EventArgs e)
        {
            valueBarCode.Focus();
            await Task.Delay(1500);
            QRGeneratorButton_Click(this, EventArgs.Empty);
        }

        private void QRGeneratorButton_Click(object sender, EventArgs e)
        {
            if (keyBarCode.Text == "" || valueBarCode.Text == "")
            {
                MessageBox.Show("Заполните поля ввода прежде, чем генерировать QR-код");
            }
            else
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode("{\n\tkey: " + keyBarCode.Text + "\n\n" + "\tvalue: " + valueBarCode.Text + "\n}", QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                pictureBoxQR.Image = qrCode.GetGraphic(3);

                if (pictureBoxQR.Size.Height > baseQRSize.Height)
                {
                    printButtonClick.Location = new Point(printButtonClick.Location.X, printButtonClick.Location.Y + (pictureBoxBarCode.Size.Height / 10 + 5));
                    pictureBoxQR.Location = new Point(pictureBoxQR.Location.X - (pictureBoxBarCode.Size.Width % 10), pictureBoxQR.Location.Y);
                }

                pictureBoxBarCode.Height = pictureBoxQR.Height;
                pictureBoxBarCode.Location = new Point(pictureBoxQR.Location.X + pictureBoxQR.Width, pictureBoxQR.Location.Y); //here
                pictureBoxBarCode.Invalidate();

                baseQRSize = pictureBoxQR.Size;

                chosePrinter_Click(this, EventArgs.Empty);
            }
        }
        private async void chosePrinter_Click(object sender, EventArgs e)
        {
            if (!isReadyToPrint && !setNothing.Checked)
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

                await Task.Delay(1000);
                keyBarCode.Text = "";
                valueBarCode.Text = "";
                keyBarCode.Focus();

            }
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(pictureBoxQR.Image, 0, 0, 76, 76);
            if (pictureBoxBarCode.Image != null) graphics.DrawImage(pictureBoxBarCode.Image, 76, 0, 36, 76);


        }

        private void setLogo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (setLogo.Checked)
            {
                listLogos.Visible = true;
                setSign.Checked = false;
                setNothing.Checked = false;
                listTitle.Visible = false;
                plusFont.Visible = false;
                minusFont.Visible = false;

                if (logoFilePath == null) pictureBoxBarCode.Image = (System.Drawing.Image)(new Bitmap(original, new Size(38, 76)));

                keyBarCode.Focus();
            }
        }

        private void setSign_CheckedChanged_1(object sender, EventArgs e)
        {
            if (setSign.Checked)
            {
                listTitle.Visible = true;
                plusFont.Visible = true;
                minusFont.Visible = true;
                setLogo.Checked = false;
                setNothing.Checked = false;
                listLogos.Visible = false;

                if (logoFilePath == null) pictureBoxBarCode.Image = (System.Drawing.Image)(new Bitmap(original, new Size(38, 76)));

                keyBarCode.Focus();
            }
        }
        private void setNothing_CheckedChanged(object sender, EventArgs e)
        {
            if (setNothing.Checked)
            {
                setLogo.Checked = false;
                setSign.Checked = false;
                listLogos.Visible = false;
                listTitle.Visible = false;
                plusFont.Visible = false;
                minusFont.Visible = false;

                pictureBoxBarCode.Image = null;
                if (logoFilePath != null) pictureBoxBarCode.Image = null;

                keyBarCode.Focus();
            }
        }

        //private void choiceLogo_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog port = new OpenFileDialog();
        //    if (port.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            var readData = new StreamReader(port.FileName);
        //            logoFilePath = port.FileName;

        //            pictureBoxBarCode.Image = Image.FromFile(logoFilePath);
        //            pictureBoxBarCode.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        //            isReadyToPrint = true;
        //            MessageBox.Show("Successful image pick!");
        //        }
        //        catch (SecurityException ex)
        //        {
        //            MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
        //        }
        //    }
        //}

        private void listLogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listLogos.SelectedItems)
            {
                int imgIndex = itm.ImageIndex;
                if (imgIndex >= 0 && imgIndex < this.imageList1.Images.Count)
                {
                    pictureBoxBarCode.Image = this.imageList1.Images[imgIndex];
                    pictureBoxBarCode.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    isReadyToPrint = true;
                }
            }

            keyBarCode.Focus();
        }

        private void listTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTitle.SelectedItem != null)
            {
                string? text = listTitle.SelectedItem.ToString();

                pictureBoxBarCode.Image = (System.Drawing.Image)(new Bitmap(original, new Size(38, 76)));
                System.Drawing.Font font = new System.Drawing.Font("Arial", fontSize);
                Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

                using (Graphics graphics = Graphics.FromImage(pictureBoxBarCode.Image))
                {
                    graphics.TranslateTransform(0, 77);
                    graphics.RotateTransform(-90);
                    graphics.DrawString(text, font, brush, 0, 0);
                    graphics.Dispose();
                }

                isReadyToPrint = true;
            }

            keyBarCode.Focus();
        }

        private void minusFont_Click(object sender, EventArgs e)
        {
            fontSize--;
            listTitle_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void plusFont_Click(object sender, EventArgs e)
        {
            fontSize++;
            listTitle_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void listLogos_DoubleClick(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void pictureBoxQR_Click(object sender, EventArgs e) { }
        private void pictureBoxGetBarCode_Paint(object sender, PaintEventArgs e) { }
    }
}