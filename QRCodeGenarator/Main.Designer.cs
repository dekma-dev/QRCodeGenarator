namespace QRCodeGenarator
{
    partial class Main
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
            pictureBoxQR = new PictureBox();
            pictureBoxBarCode = new PictureBox();
            imageList1 = new ImageList(components);
            minusButton = new MaterialSkin.Controls.MaterialButton();
            setLogoButton = new MaterialSkin.Controls.MaterialRadioButton();
            plusButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            setNothingButton = new MaterialSkin.Controls.MaterialRadioButton();
            setSignButton = new MaterialSkin.Controls.MaterialRadioButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            serialNumberTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            valueTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            materialListLogos = new MaterialSkin.Controls.MaterialListView();
            themeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            listTitles = new MaterialSkin.Controls.MaterialListBox();
            listView1 = new ListView();
            verticalSlider = new MaterialSkin.Controls.MaterialSlider();
            horizontalSlider = new MaterialSkin.Controls.MaterialSlider();
            themeIconLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarCode).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Location = new Point(158, 181);
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
            pictureBoxBarCode.Location = new Point(248, 179);
            pictureBoxBarCode.Name = "pictureBoxBarCode";
            pictureBoxBarCode.Size = new Size(38, 76);
            pictureBoxBarCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarCode.TabIndex = 11;
            pictureBoxBarCode.TabStop = false;
            pictureBoxBarCode.Paint += pictureBoxGetBarCode_Paint;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(55, 55);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // minusButton
            // 
            minusButton.AutoSize = false;
            minusButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            minusButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            minusButton.Depth = 0;
            minusButton.HighEmphasis = true;
            minusButton.Icon = null;
            minusButton.Location = new Point(476, 211);
            minusButton.Margin = new Padding(0);
            minusButton.MouseState = MaterialSkin.MouseState.HOVER;
            minusButton.Name = "minusButton";
            minusButton.NoAccentTextColor = Color.Empty;
            minusButton.Size = new Size(50, 35);
            minusButton.TabIndex = 28;
            minusButton.Text = "materialButton1";
            minusButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            minusButton.UseAccentColor = false;
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Visible = false;
            minusButton.Click += minusButton_Click_1;
            // 
            // setLogoButton
            // 
            setLogoButton.BackgroundImageLayout = ImageLayout.None;
            setLogoButton.Depth = 0;
            setLogoButton.Font = new Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setLogoButton.Location = new Point(548, 133);
            setLogoButton.Margin = new Padding(0);
            setLogoButton.MouseLocation = new Point(-1, -1);
            setLogoButton.MouseState = MaterialSkin.MouseState.HOVER;
            setLogoButton.Name = "setLogoButton";
            setLogoButton.Ripple = true;
            setLogoButton.Size = new Size(97, 37);
            setLogoButton.TabIndex = 35;
            setLogoButton.TabStop = true;
            setLogoButton.Text = "Логотип";
            setLogoButton.UseVisualStyleBackColor = true;
            setLogoButton.CheckedChanged += setLogoButton_CheckedChanged;
            // 
            // plusButton
            // 
            plusButton.AutoSize = false;
            plusButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            plusButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            plusButton.Depth = 0;
            plusButton.HighEmphasis = true;
            plusButton.Icon = null;
            plusButton.Location = new Point(419, 211);
            plusButton.Margin = new Padding(0);
            plusButton.MouseState = MaterialSkin.MouseState.HOVER;
            plusButton.Name = "plusButton";
            plusButton.NoAccentTextColor = Color.Empty;
            plusButton.Size = new Size(50, 35);
            plusButton.TabIndex = 30;
            plusButton.Text = "materialButton2";
            plusButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            plusButton.UseAccentColor = false;
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Visible = false;
            plusButton.Click += plusButton_Click_1;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            materialLabel1.Location = new Point(181, 106);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(80, 72);
            materialLabel1.TabIndex = 31;
            materialLabel1.Text = "QR";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(68, 363);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(196, 29);
            materialLabel2.TabIndex = 32;
            materialLabel2.Text = "Серийный номер";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(68, 453);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(109, 29);
            materialLabel3.TabIndex = 33;
            materialLabel3.Text = "Значение";
            // 
            // setNothingButton
            // 
            setNothingButton.BackgroundImageLayout = ImageLayout.None;
            setNothingButton.Checked = true;
            setNothingButton.Depth = 0;
            setNothingButton.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setNothingButton.Location = new Point(801, 133);
            setNothingButton.Margin = new Padding(0);
            setNothingButton.MouseLocation = new Point(-1, -1);
            setNothingButton.MouseState = MaterialSkin.MouseState.HOVER;
            setNothingButton.Name = "setNothingButton";
            setNothingButton.Ripple = true;
            setNothingButton.Size = new Size(97, 37);
            setNothingButton.TabIndex = 34;
            setNothingButton.TabStop = true;
            setNothingButton.Text = "Нет";
            setNothingButton.UseVisualStyleBackColor = true;
            setNothingButton.CheckedChanged += setNothingButton_CheckedChanged_1;
            // 
            // setSignButton
            // 
            setSignButton.BackgroundImageLayout = ImageLayout.None;
            setSignButton.Depth = 0;
            setSignButton.Font = new Font("Rockwell", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setSignButton.Location = new Point(676, 134);
            setSignButton.Margin = new Padding(0);
            setSignButton.MouseLocation = new Point(-1, -1);
            setSignButton.MouseState = MaterialSkin.MouseState.HOVER;
            setSignButton.Name = "setSignButton";
            setSignButton.Ripple = true;
            setSignButton.Size = new Size(125, 37);
            setSignButton.TabIndex = 35;
            setSignButton.TabStop = true;
            setSignButton.Text = "Надпись";
            setSignButton.UseVisualStyleBackColor = true;
            setSignButton.CheckedChanged += setSignButton_CheckedChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel4.Location = new Point(653, 95);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(148, 41);
            materialLabel4.TabIndex = 36;
            materialLabel4.Text = "Вставить";
            // 
            // serialNumberTextBox
            // 
            serialNumberTextBox.AnimateReadOnly = true;
            serialNumberTextBox.BackgroundImageLayout = ImageLayout.None;
            serialNumberTextBox.CharacterCasing = CharacterCasing.Normal;
            serialNumberTextBox.Depth = 0;
            serialNumberTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            serialNumberTextBox.HideSelection = true;
            serialNumberTextBox.LeadingIcon = null;
            serialNumberTextBox.Location = new Point(68, 393);
            serialNumberTextBox.MaximumSize = new Size(830, 48);
            serialNumberTextBox.MaxLength = 8;
            serialNumberTextBox.MinimumSize = new Size(830, 48);
            serialNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            serialNumberTextBox.Name = "serialNumberTextBox";
            serialNumberTextBox.PasswordChar = '\0';
            serialNumberTextBox.PrefixSuffixText = null;
            serialNumberTextBox.ReadOnly = false;
            serialNumberTextBox.RightToLeft = RightToLeft.No;
            serialNumberTextBox.SelectedText = "";
            serialNumberTextBox.SelectionLength = 0;
            serialNumberTextBox.SelectionStart = 0;
            serialNumberTextBox.ShortcutsEnabled = true;
            serialNumberTextBox.Size = new Size(830, 48);
            serialNumberTextBox.TabIndex = 39;
            serialNumberTextBox.TabStop = false;
            serialNumberTextBox.TextAlign = HorizontalAlignment.Left;
            serialNumberTextBox.TrailingIcon = null;
            serialNumberTextBox.UseAccent = false;
            serialNumberTextBox.UseSystemPasswordChar = false;
            serialNumberTextBox.TextChanged += serialNumberTextBox_TextChanged;
            // 
            // valueTextBox
            // 
            valueTextBox.AnimateReadOnly = true;
            valueTextBox.BackgroundImageLayout = ImageLayout.None;
            valueTextBox.CharacterCasing = CharacterCasing.Normal;
            valueTextBox.Depth = 0;
            valueTextBox.Enabled = false;
            valueTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            valueTextBox.HideSelection = true;
            valueTextBox.LeadingIcon = null;
            valueTextBox.Location = new Point(68, 483);
            valueTextBox.MaximumSize = new Size(830, 48);
            valueTextBox.MaxLength = 1000;
            valueTextBox.MinimumSize = new Size(830, 48);
            valueTextBox.MouseState = MaterialSkin.MouseState.OUT;
            valueTextBox.Name = "valueTextBox";
            valueTextBox.PasswordChar = '\0';
            valueTextBox.PrefixSuffixText = null;
            valueTextBox.ReadOnly = false;
            valueTextBox.RightToLeft = RightToLeft.No;
            valueTextBox.SelectedText = "";
            valueTextBox.SelectionLength = 0;
            valueTextBox.SelectionStart = 0;
            valueTextBox.ShortcutsEnabled = true;
            valueTextBox.Size = new Size(830, 48);
            valueTextBox.TabIndex = 40;
            valueTextBox.TabStop = false;
            valueTextBox.TextAlign = HorizontalAlignment.Left;
            valueTextBox.TrailingIcon = null;
            valueTextBox.UseAccent = false;
            valueTextBox.UseSystemPasswordChar = false;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-312, 115);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(312, 150);
            materialDrawer1.TabIndex = 41;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // materialListLogos
            // 
            materialListLogos.Activation = ItemActivation.OneClick;
            materialListLogos.AutoSizeTable = false;
            materialListLogos.BackColor = Color.FromArgb(255, 255, 255);
            materialListLogos.BorderStyle = BorderStyle.None;
            materialListLogos.Depth = 0;
            materialListLogos.FullRowSelect = true;
            materialListLogos.LargeImageList = imageList1;
            materialListLogos.Location = new Point(548, 179);
            materialListLogos.MaximumSize = new Size(350, 187);
            materialListLogos.MinimumSize = new Size(200, 100);
            materialListLogos.MouseLocation = new Point(-1, -1);
            materialListLogos.MouseState = MaterialSkin.MouseState.OUT;
            materialListLogos.MultiSelect = false;
            materialListLogos.Name = "materialListLogos";
            materialListLogos.OwnerDraw = true;
            materialListLogos.ShowItemToolTips = true;
            materialListLogos.Size = new Size(350, 187);
            materialListLogos.Sorting = SortOrder.Ascending;
            materialListLogos.TabIndex = 43;
            materialListLogos.TileSize = new Size(50, 50);
            materialListLogos.UseCompatibleStateImageBehavior = false;
            materialListLogos.View = View.Details;
            materialListLogos.Visible = false;
            materialListLogos.SelectedIndexChanged += listLogos_SelectedIndexChanged;
            // 
            // themeSwitch
            // 
            themeSwitch.BackColor = Color.BlueViolet;
            themeSwitch.CheckAlign = ContentAlignment.MiddleCenter;
            themeSwitch.Checked = true;
            themeSwitch.CheckState = CheckState.Checked;
            themeSwitch.Depth = 0;
            themeSwitch.Location = new Point(926, 89);
            themeSwitch.Margin = new Padding(0);
            themeSwitch.MouseLocation = new Point(-1, -1);
            themeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            themeSwitch.Name = "themeSwitch";
            themeSwitch.Ripple = true;
            themeSwitch.Size = new Size(51, 26);
            themeSwitch.TabIndex = 44;
            themeSwitch.UseVisualStyleBackColor = false;
            themeSwitch.CheckedChanged += themeSwitch_CheckedChanged;
            // 
            // listTitles
            // 
            listTitles.BackColor = Color.White;
            listTitles.BorderColor = Color.LightGray;
            listTitles.Depth = 0;
            listTitles.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listTitles.Location = new Point(548, 179);
            listTitles.MaximumSize = new Size(350, 192);
            listTitles.MouseState = MaterialSkin.MouseState.HOVER;
            listTitles.Name = "listTitles";
            listTitles.SelectedIndex = -1;
            listTitles.SelectedItem = null;
            listTitles.Size = new Size(350, 192);
            listTitles.TabIndex = 46;
            listTitles.Visible = false;
            listTitles.SelectedIndexChanged += listTitles_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.None;
            listView1.ForeColor = SystemColors.Window;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(548, 176);
            listView1.Name = "listView1";
            listView1.Size = new Size(350, 190);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 47;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Visible = false;
            listView1.Click += listLogos_SelectedIndexChanged;
            // 
            // verticalSlider
            // 
            verticalSlider.Cursor = Cursors.Hand;
            verticalSlider.Depth = 0;
            verticalSlider.ForeColor = Color.FromArgb(222, 0, 0, 0);
            verticalSlider.Location = new Point(418, 300);
            verticalSlider.MouseState = MaterialSkin.MouseState.HOVER;
            verticalSlider.Name = "verticalSlider";
            verticalSlider.RangeMax = 25;
            verticalSlider.ShowValue = false;
            verticalSlider.Size = new Size(127, 40);
            verticalSlider.TabIndex = 48;
            verticalSlider.Text = "Y";
            verticalSlider.Value = 0;
            verticalSlider.Visible = false;
            verticalSlider.Click += slider_Click;
            // 
            // horizontalSlider
            // 
            horizontalSlider.Cursor = Cursors.Hand;
            horizontalSlider.Depth = 0;
            horizontalSlider.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            horizontalSlider.ForeColor = Color.FromArgb(222, 0, 0, 0);
            horizontalSlider.Location = new Point(418, 260);
            horizontalSlider.MouseState = MaterialSkin.MouseState.HOVER;
            horizontalSlider.Name = "horizontalSlider";
            horizontalSlider.RangeMax = 20;
            horizontalSlider.ShowValue = false;
            horizontalSlider.Size = new Size(127, 40);
            horizontalSlider.TabIndex = 49;
            horizontalSlider.Text = "X";
            horizontalSlider.Value = 0;
            horizontalSlider.Visible = false;
            horizontalSlider.Click += horizontalSlider_Click;
            // 
            // themeIconLabel
            // 
            themeIconLabel.AutoSize = true;
            themeIconLabel.Depth = 0;
            themeIconLabel.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            themeIconLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            themeIconLabel.Location = new Point(894, 88);
            themeIconLabel.MouseState = MaterialSkin.MouseState.HOVER;
            themeIconLabel.Name = "themeIconLabel";
            themeIconLabel.Size = new Size(14, 29);
            themeIconLabel.TabIndex = 51;
            themeIconLabel.Text = "L";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(977, 570);
            Controls.Add(themeIconLabel);
            Controls.Add(horizontalSlider);
            Controls.Add(verticalSlider);
            Controls.Add(listView1);
            Controls.Add(listTitles);
            Controls.Add(themeSwitch);
            Controls.Add(materialListLogos);
            Controls.Add(materialDrawer1);
            Controls.Add(valueTextBox);
            Controls.Add(serialNumberTextBox);
            Controls.Add(materialLabel4);
            Controls.Add(setSignButton);
            Controls.Add(setNothingButton);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(plusButton);
            Controls.Add(setLogoButton);
            Controls.Add(minusButton);
            Controls.Add(pictureBoxBarCode);
            Controls.Add(pictureBoxQR);
            DrawerIndicatorWidth = 50;
            Font = new Font("Rockwell Extra Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormStyle = FormStyles.ActionBar_64;
            MaximizeBox = false;
            MaximumSize = new Size(977, 570);
            MinimizeBox = false;
            MinimumSize = new Size(977, 570);
            Name = "Main";
            Padding = new Padding(3, 90, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QR Code Generator";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxQR;
        private PictureBox pictureBoxBarCode;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton minusButton;
        private MaterialSkin.Controls.MaterialRadioButton setLogoButton;
        private MaterialSkin.Controls.MaterialButton plusButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton setNothingButton;
        private MaterialSkin.Controls.MaterialRadioButton setSignButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 serialNumberTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 valueTextBox;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialListView materialListLogos;
        private MaterialSkin.Controls.MaterialSwitch themeSwitch;
        private MaterialSkin.Controls.MaterialListBox listTitles;
        private ListView listView1;
        private MaterialSkin.Controls.MaterialSlider verticalSlider;
        private MaterialSkin.Controls.MaterialSlider horizontalSlider;
        private MaterialSkin.Controls.MaterialLabel themeIconLabel;
    }
}