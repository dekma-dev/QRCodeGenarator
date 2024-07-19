namespace QRCodeGenarator
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            applyBut = new MaterialSkin.Controls.MaterialButton();
            hostTB = new MaterialSkin.Controls.MaterialTextBox2();
            portTB = new MaterialSkin.Controls.MaterialTextBox2();
            dbTB = new MaterialSkin.Controls.MaterialTextBox2();
            loginTB = new MaterialSkin.Controls.MaterialTextBox2();
            passTB = new MaterialSkin.Controls.MaterialTextBox2();
            tableTB = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(18, 108);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(52, 29);
            materialLabel1.TabIndex = 15;
            materialLabel1.Text = "Host";
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(18, 169);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 29);
            materialLabel2.TabIndex = 16;
            materialLabel2.Text = "Port";
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(18, 353);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(107, 29);
            materialLabel3.TabIndex = 17;
            materialLabel3.Text = "Password";
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel4.Location = new Point(18, 291);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(110, 29);
            materialLabel4.TabIndex = 18;
            materialLabel4.Text = "Username";
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel5.Location = new Point(18, 230);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(102, 29);
            materialLabel5.TabIndex = 19;
            materialLabel5.Text = "Database";
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel6.Location = new Point(18, 415);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(60, 29);
            materialLabel6.TabIndex = 20;
            materialLabel6.Text = "Table";
            // 
            // applyBut
            // 
            applyBut.AutoSize = false;
            applyBut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            applyBut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            applyBut.Depth = 0;
            applyBut.Font = new Font("Rockwell", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applyBut.HighEmphasis = true;
            applyBut.Icon = null;
            applyBut.Location = new Point(565, 415);
            applyBut.Margin = new Padding(4, 6, 4, 6);
            applyBut.MouseState = MaterialSkin.MouseState.HOVER;
            applyBut.Name = "applyBut";
            applyBut.NoAccentTextColor = Color.Empty;
            applyBut.Size = new Size(103, 48);
            applyBut.TabIndex = 22;
            applyBut.Text = "Apply";
            applyBut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            applyBut.UseAccentColor = false;
            applyBut.UseVisualStyleBackColor = true;
            applyBut.Click += applyBut_Click;
            // 
            // hostTB
            // 
            hostTB.AnimateReadOnly = false;
            hostTB.BackgroundImageLayout = ImageLayout.None;
            hostTB.CharacterCasing = CharacterCasing.Normal;
            hostTB.Depth = 0;
            hostTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            hostTB.HideSelection = true;
            hostTB.LeadingIcon = null;
            hostTB.Location = new Point(143, 108);
            hostTB.MaxLength = 32767;
            hostTB.MinimumSize = new Size(400, 48);
            hostTB.MouseState = MaterialSkin.MouseState.OUT;
            hostTB.Name = "hostTB";
            hostTB.PasswordChar = '\0';
            hostTB.PrefixSuffixText = null;
            hostTB.ReadOnly = false;
            hostTB.RightToLeft = RightToLeft.No;
            hostTB.SelectedText = "";
            hostTB.SelectionLength = 0;
            hostTB.SelectionStart = 0;
            hostTB.ShortcutsEnabled = true;
            hostTB.Size = new Size(400, 48);
            hostTB.TabIndex = 46;
            hostTB.TabStop = false;
            hostTB.Text = "127.0.0.1";
            hostTB.TextAlign = HorizontalAlignment.Left;
            hostTB.TrailingIcon = null;
            hostTB.UseSystemPasswordChar = false;
            // 
            // portTB
            // 
            portTB.AnimateReadOnly = false;
            portTB.BackgroundImageLayout = ImageLayout.None;
            portTB.CharacterCasing = CharacterCasing.Normal;
            portTB.Depth = 0;
            portTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            portTB.HideSelection = true;
            portTB.LeadingIcon = null;
            portTB.Location = new Point(143, 169);
            portTB.MaxLength = 32767;
            portTB.MinimumSize = new Size(400, 48);
            portTB.MouseState = MaterialSkin.MouseState.OUT;
            portTB.Name = "portTB";
            portTB.PasswordChar = '\0';
            portTB.PrefixSuffixText = null;
            portTB.ReadOnly = false;
            portTB.RightToLeft = RightToLeft.No;
            portTB.SelectedText = "";
            portTB.SelectionLength = 0;
            portTB.SelectionStart = 0;
            portTB.ShortcutsEnabled = true;
            portTB.Size = new Size(400, 48);
            portTB.TabIndex = 47;
            portTB.TabStop = false;
            portTB.Text = "5432";
            portTB.TextAlign = HorizontalAlignment.Left;
            portTB.TrailingIcon = null;
            portTB.UseSystemPasswordChar = false;
            // 
            // dbTB
            // 
            dbTB.AnimateReadOnly = false;
            dbTB.BackgroundImageLayout = ImageLayout.None;
            dbTB.CharacterCasing = CharacterCasing.Normal;
            dbTB.Depth = 0;
            dbTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dbTB.HideSelection = true;
            dbTB.LeadingIcon = null;
            dbTB.Location = new Point(143, 230);
            dbTB.MaxLength = 32767;
            dbTB.MinimumSize = new Size(400, 48);
            dbTB.MouseState = MaterialSkin.MouseState.OUT;
            dbTB.Name = "dbTB";
            dbTB.PasswordChar = '\0';
            dbTB.PrefixSuffixText = null;
            dbTB.ReadOnly = false;
            dbTB.RightToLeft = RightToLeft.No;
            dbTB.SelectedText = "";
            dbTB.SelectionLength = 0;
            dbTB.SelectionStart = 0;
            dbTB.ShortcutsEnabled = true;
            dbTB.Size = new Size(400, 48);
            dbTB.TabIndex = 48;
            dbTB.TabStop = false;
            dbTB.Text = "postgres";
            dbTB.TextAlign = HorizontalAlignment.Left;
            dbTB.TrailingIcon = null;
            dbTB.UseSystemPasswordChar = false;
            // 
            // loginTB
            // 
            loginTB.AnimateReadOnly = false;
            loginTB.BackgroundImageLayout = ImageLayout.None;
            loginTB.CharacterCasing = CharacterCasing.Normal;
            loginTB.Depth = 0;
            loginTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginTB.HideSelection = true;
            loginTB.LeadingIcon = null;
            loginTB.Location = new Point(143, 291);
            loginTB.MaxLength = 32767;
            loginTB.MinimumSize = new Size(400, 48);
            loginTB.MouseState = MaterialSkin.MouseState.OUT;
            loginTB.Name = "loginTB";
            loginTB.PasswordChar = '\0';
            loginTB.PrefixSuffixText = null;
            loginTB.ReadOnly = false;
            loginTB.RightToLeft = RightToLeft.No;
            loginTB.SelectedText = "";
            loginTB.SelectionLength = 0;
            loginTB.SelectionStart = 0;
            loginTB.ShortcutsEnabled = true;
            loginTB.Size = new Size(400, 48);
            loginTB.TabIndex = 49;
            loginTB.TabStop = false;
            loginTB.Text = "postgres";
            loginTB.TextAlign = HorizontalAlignment.Left;
            loginTB.TrailingIcon = null;
            loginTB.UseSystemPasswordChar = false;
            // 
            // passTB
            // 
            passTB.AnimateReadOnly = false;
            passTB.BackgroundImageLayout = ImageLayout.None;
            passTB.CharacterCasing = CharacterCasing.Normal;
            passTB.Depth = 0;
            passTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passTB.HideSelection = true;
            passTB.LeadingIcon = null;
            passTB.Location = new Point(143, 353);
            passTB.MaxLength = 32767;
            passTB.MinimumSize = new Size(400, 48);
            passTB.MouseState = MaterialSkin.MouseState.OUT;
            passTB.Name = "passTB";
            passTB.PasswordChar = '\0';
            passTB.PrefixSuffixText = null;
            passTB.ReadOnly = false;
            passTB.RightToLeft = RightToLeft.No;
            passTB.SelectedText = "";
            passTB.SelectionLength = 0;
            passTB.SelectionStart = 0;
            passTB.ShortcutsEnabled = true;
            passTB.Size = new Size(400, 48);
            passTB.TabIndex = 50;
            passTB.TabStop = false;
            passTB.TextAlign = HorizontalAlignment.Left;
            passTB.TrailingIcon = null;
            passTB.UseSystemPasswordChar = false;
            // 
            // tableTB
            // 
            tableTB.AnimateReadOnly = false;
            tableTB.BackgroundImageLayout = ImageLayout.None;
            tableTB.CharacterCasing = CharacterCasing.Normal;
            tableTB.Depth = 0;
            tableTB.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tableTB.HideSelection = true;
            tableTB.LeadingIcon = null;
            tableTB.Location = new Point(143, 415);
            tableTB.MaxLength = 32767;
            tableTB.MinimumSize = new Size(400, 48);
            tableTB.MouseState = MaterialSkin.MouseState.OUT;
            tableTB.Name = "tableTB";
            tableTB.PasswordChar = '\0';
            tableTB.PrefixSuffixText = null;
            tableTB.ReadOnly = false;
            tableTB.RightToLeft = RightToLeft.No;
            tableTB.SelectedText = "";
            tableTB.SelectionLength = 0;
            tableTB.SelectionStart = 0;
            tableTB.ShortcutsEnabled = true;
            tableTB.Size = new Size(400, 48);
            tableTB.TabIndex = 51;
            tableTB.TabStop = false;
            tableTB.Text = "user";
            tableTB.TextAlign = HorizontalAlignment.Left;
            tableTB.TrailingIcon = null;
            tableTB.UseSystemPasswordChar = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 485);
            Controls.Add(tableTB);
            Controls.Add(passTB);
            Controls.Add(loginTB);
            Controls.Add(dbTB);
            Controls.Add(portTB);
            Controls.Add(hostTB);
            Controls.Add(applyBut);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            FormStyle = FormStyles.ActionBar_64;
            Margin = new Padding(6, 5, 6, 5);
            MaximumSize = new Size(700, 485);
            MinimumSize = new Size(700, 485);
            Name = "Settings";
            Padding = new Padding(3, 88, 4, 4);
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton applyBut;
        private MaterialSkin.Controls.MaterialTextBox2 hostTB;
        private MaterialSkin.Controls.MaterialTextBox2 portTB;
        private MaterialSkin.Controls.MaterialTextBox2 dbTB;
        private MaterialSkin.Controls.MaterialTextBox2 loginTB;
        private MaterialSkin.Controls.MaterialTextBox2 passTB;
        private MaterialSkin.Controls.MaterialTextBox2 tableTB;
    }
}