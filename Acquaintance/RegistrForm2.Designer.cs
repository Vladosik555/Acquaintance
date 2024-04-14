namespace Acquaintance
{
    partial class RegistrForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrForm2));
            nameLabel = new Label();
            nameField = new TextBox();
            BirhdayLabel = new Label();
            BirhdayFields = new TextBox();
            surnameLabel = new Label();
            surnameField = new TextBox();
            gradientPanel2 = new GradientPanel();
            continueButton = new Button();
            registrPanel = new GradientPanel();
            button1 = new Button();
            CloseButton = new Button();
            RegistrLabel = new Label();
            cityLabel = new Label();
            cityField = new TextBox();
            sexLabel = new Label();
            sexMenButtun = new RadioButton();
            sexWomenButton = new RadioButton();
            boyPhoto = new PictureBox();
            girlPhoto = new PictureBox();
            gradientPanel2.SuspendLayout();
            registrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(70, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Имя";
            // 
            // nameField
            // 
            nameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.Location = new Point(70, 130);
            nameField.Name = "nameField";
            nameField.Size = new Size(297, 29);
            nameField.TabIndex = 23;
            nameField.Text = "Введите имя...";
            // 
            // BirhdayLabel
            // 
            BirhdayLabel.AutoSize = true;
            BirhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BirhdayLabel.Location = new Point(70, 221);
            BirhdayLabel.Name = "BirhdayLabel";
            BirhdayLabel.Size = new Size(151, 24);
            BirhdayLabel.TabIndex = 22;
            BirhdayLabel.Text = "Дата рождения";
            // 
            // BirhdayFields
            // 
            BirhdayFields.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirhdayFields.Location = new Point(70, 248);
            BirhdayFields.Name = "BirhdayFields";
            BirhdayFields.Size = new Size(297, 29);
            BirhdayFields.TabIndex = 21;
            BirhdayFields.Text = "Введите дату рождения...";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(70, 162);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 20;
            surnameLabel.Text = "Фамилия";
            // 
            // surnameField
            // 
            surnameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.Location = new Point(70, 189);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(297, 29);
            surnameField.TabIndex = 19;
            surnameField.Text = "Введите фамилию...";
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel2.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel2.Controls.Add(continueButton);
            gradientPanel2.Location = new Point(96, 377);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(224, 62);
            gradientPanel2.TabIndex = 18;
            // 
            // continueButton
            // 
            continueButton.BackColor = Color.Transparent;
            continueButton.BackgroundImageLayout = ImageLayout.None;
            continueButton.FlatAppearance.BorderSize = 0;
            continueButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            continueButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            continueButton.FlatStyle = FlatStyle.Flat;
            continueButton.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            continueButton.ForeColor = Color.White;
            continueButton.Location = new Point(0, 0);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(224, 62);
            continueButton.TabIndex = 2;
            continueButton.Text = "Далее";
            continueButton.UseVisualStyleBackColor = false;
            // 
            // registrPanel
            // 
            registrPanel.Angle = 0F;
            registrPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            registrPanel.ColorTop = Color.FromArgb(141, 11, 173);
            registrPanel.Controls.Add(girlPhoto);
            registrPanel.Controls.Add(boyPhoto);
            registrPanel.Controls.Add(button1);
            registrPanel.Controls.Add(CloseButton);
            registrPanel.Controls.Add(RegistrLabel);
            registrPanel.Dock = DockStyle.Top;
            registrPanel.Location = new Point(0, 0);
            registrPanel.Name = "registrPanel";
            registrPanel.Size = new Size(419, 100);
            registrPanel.TabIndex = 17;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(350, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 23);
            button1.TabIndex = 24;
            button1.Text = "—";
            button1.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(384, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 21;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // RegistrLabel
            // 
            RegistrLabel.AutoSize = true;
            RegistrLabel.BackColor = Color.Transparent;
            RegistrLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegistrLabel.ForeColor = Color.White;
            RegistrLabel.Location = new Point(70, 26);
            RegistrLabel.Name = "RegistrLabel";
            RegistrLabel.Size = new Size(281, 64);
            RegistrLabel.TabIndex = 0;
            RegistrLabel.Text = "Регистрация";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(70, 280);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 25;
            cityLabel.Text = "Город";
            // 
            // cityField
            // 
            cityField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.Location = new Point(70, 307);
            cityField.Name = "cityField";
            cityField.Size = new Size(297, 29);
            cityField.TabIndex = 26;
            cityField.Text = "Введите город...";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(70, 343);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(144, 24);
            sexLabel.TabIndex = 27;
            sexLabel.Text = "Выберите пол";
            // 
            // sexMenButtun
            // 
            sexMenButtun.AutoSize = true;
            sexMenButtun.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexMenButtun.Location = new Point(222, 344);
            sexMenButtun.Name = "sexMenButtun";
            sexMenButtun.Size = new Size(46, 27);
            sexMenButtun.TabIndex = 28;
            sexMenButtun.TabStop = true;
            sexMenButtun.Text = "M";
            sexMenButtun.UseVisualStyleBackColor = true;
            // 
            // sexWomenButton
            // 
            sexWomenButton.AutoSize = true;
            sexWomenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexWomenButton.Location = new Point(284, 344);
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.Size = new Size(47, 27);
            sexWomenButton.TabIndex = 29;
            sexWomenButton.TabStop = true;
            sexWomenButton.Text = "Ж";
            sexWomenButton.UseVisualStyleBackColor = true;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Transparent;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(12, 26);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 25;
            boyPhoto.TabStop = false;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(344, 26);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 26;
            girlPhoto.TabStop = false;
            // 
            // RegistrForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 450);
            Controls.Add(sexWomenButton);
            Controls.Add(sexMenButtun);
            Controls.Add(sexLabel);
            Controls.Add(cityField);
            Controls.Add(cityLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameField);
            Controls.Add(BirhdayLabel);
            Controls.Add(BirhdayFields);
            Controls.Add(surnameLabel);
            Controls.Add(surnameField);
            Controls.Add(gradientPanel2);
            Controls.Add(registrPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrForm2";
            Text = "RegistrForm2";
            gradientPanel2.ResumeLayout(false);
            registrPanel.ResumeLayout(false);
            registrPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameField;
        private Label BirhdayLabel;
        private TextBox BirhdayFields;
        private Label surnameLabel;
        private TextBox surnameField;
        private GradientPanel gradientPanel2;
        private Button continueButton;
        private GradientPanel registrPanel;
        private Button button1;
        private Button CloseButton;
        private Label RegistrLabel;
        private Label cityLabel;
        private TextBox cityField;
        private Label sexLabel;
        private RadioButton sexMenButtun;
        private RadioButton sexWomenButton;
        private PictureBox boyPhoto;
        private PictureBox girlPhoto;
    }
}