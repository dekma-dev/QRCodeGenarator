namespace QRCodeGenarator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            keyBarCode = new TextBox();
            textBoxLabel = new Label();
            pictureBoxLabel = new Label();
            pictureBoxQR = new PictureBox();
            pictureBoxBarCode = new PictureBox();
            label1 = new Label();
            valueBarCode = new TextBox();
            label2 = new Label();
            setLogo = new RadioButton();
            setSign = new RadioButton();
            listTitle = new ListBox();
            setNothing = new RadioButton();
            imageList1 = new ImageList(components);
            listLogos = new ListView();
            plusFont = new Button();
            minusFont = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarCode).BeginInit();
            SuspendLayout();
            // 
            // keyBarCode
            // 
            keyBarCode.Location = new Point(135, 380);
            keyBarCode.Name = "keyBarCode";
            keyBarCode.Size = new Size(753, 30);
            keyBarCode.TabIndex = 1;
            keyBarCode.TextChanged += keyBarCode_TextChanged;
            // 
            // textBoxLabel
            // 
            textBoxLabel.AutoSize = true;
            textBoxLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLabel.Location = new Point(135, 348);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(157, 22);
            textBoxLabel.TabIndex = 2;
            textBoxLabel.Text = "Серийный номер";
            textBoxLabel.Visible = false;
            // 
            // pictureBoxLabel
            // 
            pictureBoxLabel.AutoSize = true;
            pictureBoxLabel.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            pictureBoxLabel.Location = new Point(443, 51);
            pictureBoxLabel.Name = "pictureBoxLabel";
            pictureBoxLabel.Size = new Size(118, 68);
            pictureBoxLabel.TabIndex = 3;
            pictureBoxLabel.Text = "QR";
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Location = new Point(433, 143);
            pictureBoxQR.Margin = new Padding(0);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(76, 76);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxQR.TabIndex = 0;
            pictureBoxQR.TabStop = false;
            pictureBoxQR.Click += pictureBoxQR_Click;
            // 
            // pictureBoxBarCode
            // 
            pictureBoxBarCode.Location = new Point(523, 139);
            pictureBoxBarCode.Name = "pictureBoxBarCode";
            pictureBoxBarCode.Size = new Size(38, 76);
            pictureBoxBarCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarCode.TabIndex = 11;
            pictureBoxBarCode.TabStop = false;
            pictureBoxBarCode.Paint += pictureBoxGetBarCode_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(135, 411);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 13;
            label1.Text = "Значение";
            label1.Visible = false;
            // 
            // valueBarCode
            // 
            valueBarCode.Enabled = false;
            valueBarCode.Location = new Point(135, 441);
            valueBarCode.Name = "valueBarCode";
            valueBarCode.Size = new Size(753, 30);
            valueBarCode.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(739, 71);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 19;
            label2.Text = "Вставить:";
            // 
            // setLogo
            // 
            setLogo.AutoSize = true;
            setLogo.Font = new Font("Times New Roman", 12F);
            setLogo.Location = new Point(645, 111);
            setLogo.Name = "setLogo";
            setLogo.Size = new Size(104, 26);
            setLogo.TabIndex = 20;
            setLogo.Text = "Логотип";
            setLogo.UseVisualStyleBackColor = true;
            setLogo.CheckedChanged += setLogo_CheckedChanged_1;
            // 
            // setSign
            // 
            setSign.AutoSize = true;
            setSign.Font = new Font("Times New Roman", 12F);
            setSign.Location = new Point(755, 111);
            setSign.Name = "setSign";
            setSign.Size = new Size(104, 26);
            setSign.TabIndex = 21;
            setSign.Text = "Надпись";
            setSign.UseVisualStyleBackColor = true;
            setSign.CheckedChanged += setSign_CheckedChanged_1;
            // 
            // listTitle
            // 
            listTitle.FormattingEnabled = true;
            listTitle.ItemHeight = 22;
            listTitle.Location = new Point(651, 153);
            listTitle.Name = "listTitle";
            listTitle.Size = new Size(273, 92);
            listTitle.TabIndex = 23;
            listTitle.Visible = false;
            listTitle.SelectedIndexChanged += listTitle_SelectedIndexChanged;
            // 
            // setNothing
            // 
            setNothing.AutoSize = true;
            setNothing.Checked = true;
            setNothing.Font = new Font("Times New Roman", 12F);
            setNothing.Location = new Point(865, 111);
            setNothing.Name = "setNothing";
            setNothing.Size = new Size(63, 26);
            setNothing.TabIndex = 24;
            setNothing.TabStop = true;
            setNothing.Text = "Нет";
            setNothing.UseVisualStyleBackColor = true;
            setNothing.CheckedChanged += setNothing_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(68, 75);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listLogos
            // 
            listLogos.LargeImageList = imageList1;
            listLogos.Location = new Point(651, 153);
            listLogos.Name = "listLogos";
            listLogos.Size = new Size(273, 192);
            listLogos.TabIndex = 25;
            listLogos.UseCompatibleStateImageBehavior = false;
            listLogos.Visible = false;
            listLogos.Click += listLogos_SelectedIndexChanged;
            // 
            // plusFont
            // 
            plusFont.FlatStyle = FlatStyle.Popup;
            plusFont.Location = new Point(608, 191);
            plusFont.Name = "plusFont";
            plusFont.Size = new Size(37, 29);
            plusFont.TabIndex = 26;
            plusFont.Text = "char.ConvertFromUtf32(0x2193)";
            plusFont.UseVisualStyleBackColor = true;
            plusFont.Visible = false;
            plusFont.Click += plusFont_Click;
            // 
            // minusFont
            // 
            minusFont.FlatStyle = FlatStyle.Popup;
            minusFont.Location = new Point(608, 216);
            minusFont.Name = "minusFont";
            minusFont.Size = new Size(37, 29);
            minusFont.TabIndex = 27;
            minusFont.Text = "char.ConvertFromUtf32(0x2191)";
            minusFont.UseVisualStyleBackColor = true;
            minusFont.Visible = false;
            minusFont.Click += minusFont_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(969, 565);
            Controls.Add(minusFont);
            Controls.Add(plusFont);
            Controls.Add(listLogos);
            Controls.Add(setNothing);
            Controls.Add(listTitle);
            Controls.Add(setSign);
            Controls.Add(setLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valueBarCode);
            Controls.Add(pictureBoxBarCode);
            Controls.Add(pictureBoxQR);
            Controls.Add(pictureBoxLabel);
            Controls.Add(textBoxLabel);
            Controls.Add(keyBarCode);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 12F);
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox keyBarCode;
        private Label textBoxLabel;
        private Label pictureBoxLabel;
        private PictureBox pictureBoxQR;
        private PictureBox pictureBoxBarCode;
        private Label label1;
        private TextBox valueBarCode;
        private Label label2;
        private RadioButton setLogo;
        private RadioButton setSign;
        private ListBox listTitle;
        private RadioButton setNothing;
        private ImageList imageList1;
        private ListView listLogos;
        private Button plusFont;
        private Button minusFont;
    }
}