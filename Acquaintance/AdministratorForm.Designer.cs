namespace Acquaintance
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            applicationPanel = new GradientPanel();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            UsersList = new ListView();
            label2 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            numberLabel = new Label();
            emailLabel = new Label();
            numberField = new Label();
            emailField = new Label();
            sexField = new Label();
            cityField = new Label();
            birhdayField = new Label();
            surnameField = new Label();
            nameField = new Label();
            gradientPanel2 = new GradientPanel();
            deleteAccountButton = new Button();
            sexLabel = new Label();
            cityLabel = new Label();
            nameLabel = new Label();
            birhdayLabel = new Label();
            surnameLabel = new Label();
            Photo = new PictureBox();
            profileLabel = new Label();
            panel1 = new Panel();
            usersLabel = new Label();
            boyPhoto = new PictureBox();
            girlPhoto = new PictureBox();
            applicationPanel.SuspendLayout();
            panel2.SuspendLayout();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            SuspendLayout();
            // 
            // applicationPanel
            // 
            applicationPanel.Angle = 0F;
            applicationPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            applicationPanel.ColorTop = Color.FromArgb(141, 11, 173);
            applicationPanel.Controls.Add(girlPhoto);
            applicationPanel.Controls.Add(boyPhoto);
            applicationPanel.Controls.Add(CollapseButton);
            applicationPanel.Controls.Add(CloseButton);
            applicationPanel.Controls.Add(entryLabel);
            applicationPanel.Dock = DockStyle.Top;
            applicationPanel.Location = new Point(0, 0);
            applicationPanel.Name = "applicationPanel";
            applicationPanel.Size = new Size(875, 90);
            applicationPanel.TabIndex = 2;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Bottom;
            CollapseButton.BackColor = Color.Transparent;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Location = new Point(809, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 23;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
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
            CloseButton.Location = new Point(839, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 21;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = Color.Transparent;
            entryLabel.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = Color.White;
            entryLabel.Location = new Point(143, 4);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(519, 84);
            entryLabel.TabIndex = 0;
            entryLabel.Text = "Трепетание сердца";
            // 
            // UsersList
            // 
            UsersList.Location = new Point(-1, 53);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(265, 309);
            UsersList.TabIndex = 20;
            UsersList.UseCompatibleStateImageBehavior = false;
            UsersList.View = View.List;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(266, 91);
            label2.Name = "label2";
            label2.Size = new Size(10, 362);
            label2.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(numberLabel);
            panel2.Controls.Add(emailLabel);
            panel2.Controls.Add(numberField);
            panel2.Controls.Add(emailField);
            panel2.Controls.Add(sexField);
            panel2.Controls.Add(cityField);
            panel2.Controls.Add(birhdayField);
            panel2.Controls.Add(surnameField);
            panel2.Controls.Add(nameField);
            panel2.Controls.Add(gradientPanel2);
            panel2.Controls.Add(sexLabel);
            panel2.Controls.Add(cityLabel);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(birhdayLabel);
            panel2.Controls.Add(surnameLabel);
            panel2.Controls.Add(Photo);
            panel2.Controls.Add(profileLabel);
            panel2.Location = new Point(277, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 359);
            panel2.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(461, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 55;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(164, 281);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(167, 24);
            numberLabel.TabIndex = 53;
            numberLabel.Text = "Номер телефона";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(265, 242);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 24);
            emailLabel.TabIndex = 52;
            emailLabel.Text = "Почта";
            // 
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Gray;
            numberField.Location = new Point(350, 281);
            numberField.Name = "numberField";
            numberField.Size = new Size(235, 24);
            numberField.TabIndex = 51;
            numberField.Text = "Номер телефона";
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.ForeColor = Color.Gray;
            emailField.Location = new Point(350, 243);
            emailField.Name = "emailField";
            emailField.Size = new Size(235, 24);
            emailField.TabIndex = 50;
            emailField.Text = "Почта";
            // 
            // sexField
            // 
            sexField.BackColor = Color.FromArgb(255, 230, 255);
            sexField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexField.ForeColor = Color.Gray;
            sexField.Location = new Point(350, 207);
            sexField.Name = "sexField";
            sexField.Size = new Size(235, 24);
            sexField.TabIndex = 49;
            sexField.Text = "Пол";
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Gray;
            cityField.Location = new Point(350, 171);
            cityField.Name = "cityField";
            cityField.Size = new Size(235, 24);
            cityField.TabIndex = 48;
            cityField.Text = "Город";
            // 
            // birhdayField
            // 
            birhdayField.BackColor = Color.FromArgb(255, 230, 255);
            birhdayField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birhdayField.ForeColor = Color.Gray;
            birhdayField.Location = new Point(350, 135);
            birhdayField.Name = "birhdayField";
            birhdayField.Size = new Size(235, 24);
            birhdayField.TabIndex = 47;
            birhdayField.Text = "Дата рождения";
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Gray;
            surnameField.Location = new Point(350, 100);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(235, 24);
            surnameField.TabIndex = 46;
            surnameField.Text = "Фамилия";
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Gray;
            nameField.Location = new Point(350, 65);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 45;
            nameField.Text = "Имя";
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel2.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel2.Controls.Add(deleteAccountButton);
            gradientPanel2.Location = new Point(5, 320);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(267, 38);
            gradientPanel2.TabIndex = 44;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.BackColor = Color.Transparent;
            deleteAccountButton.BackgroundImageLayout = ImageLayout.None;
            deleteAccountButton.FlatAppearance.BorderSize = 0;
            deleteAccountButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            deleteAccountButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            deleteAccountButton.FlatStyle = FlatStyle.Flat;
            deleteAccountButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteAccountButton.ForeColor = Color.White;
            deleteAccountButton.Location = new Point(0, 0);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(267, 38);
            deleteAccountButton.TabIndex = 3;
            deleteAccountButton.Text = "Заблокировать аккаунт";
            deleteAccountButton.UseVisualStyleBackColor = false;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(282, 206);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(49, 24);
            sexLabel.TabIndex = 38;
            sexLabel.Text = "Пол";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(267, 170);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 36;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(282, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 35;
            nameLabel.Text = "Имя";
            // 
            // birhdayLabel
            // 
            birhdayLabel.AutoSize = true;
            birhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birhdayLabel.Location = new Point(182, 135);
            birhdayLabel.Name = "birhdayLabel";
            birhdayLabel.Size = new Size(151, 24);
            birhdayLabel.TabIndex = 33;
            birhdayLabel.Text = "Дата рождения";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(232, 100);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 31;
            surnameLabel.Text = "Фамилия";
            // 
            // Photo
            // 
            Photo.Image = (Image)resources.GetObject("Photo.Image");
            Photo.Location = new Point(21, 69);
            Photo.Name = "Photo";
            Photo.Size = new Size(155, 149);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 1;
            Photo.TabStop = false;
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            profileLabel.Location = new Point(150, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(198, 64);
            profileLabel.TabIndex = 0;
            profileLabel.Text = "Профиль";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(usersLabel);
            panel1.Controls.Add(UsersList);
            panel1.Location = new Point(0, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 358);
            panel1.TabIndex = 23;
            // 
            // usersLabel
            // 
            usersLabel.AutoSize = true;
            usersLabel.Font = new Font("Segoe Print", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usersLabel.Location = new Point(12, 0);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(235, 50);
            usersLabel.TabIndex = 21;
            usersLabel.Text = "Пользователи";
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Transparent;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(70, 12);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(79, 73);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 25;
            boyPhoto.TabStop = false;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(655, 12);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(74, 73);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 28;
            girlPhoto.TabStop = false;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(applicationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            applicationPanel.ResumeLayout(false);
            applicationPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel applicationPanel;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private ListView UsersList;
        private Label label2;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label numberLabel;
        private Label emailLabel;
        private Label numberField;
        private Label emailField;
        private Label sexField;
        private Label cityField;
        private Label birhdayField;
        private Label surnameField;
        private Label nameField;
        private GradientPanel gradientPanel2;
        private Button deleteAccountButton;
        private Label sexLabel;
        private Label cityLabel;
        private Label nameLabel;
        private Label birhdayLabel;
        private Label surnameLabel;
        private PictureBox Photo;
        private Label profileLabel;
        private Panel panel1;
        private Label usersLabel;
        private PictureBox boyPhoto;
        private PictureBox girlPhoto;
    }
}