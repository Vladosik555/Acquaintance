namespace Acquaintance
{
    partial class EditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            applicationPanel = new GradientPanel();
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            button1 = new Button();
            CloseButton = new Button();
            redactionLabel = new Label();
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
            redactionButton = new Button();
            sexLabel = new Label();
            cityLabel = new Label();
            nameLabel = new Label();
            birhdayLabel = new Label();
            surnameLabel = new Label();
            applicationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // applicationPanel
            // 
            applicationPanel.Angle = 0F;
            applicationPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            applicationPanel.ColorTop = Color.FromArgb(141, 11, 173);
            applicationPanel.Controls.Add(girlPhoto);
            applicationPanel.Controls.Add(boyPhoto);
            applicationPanel.Controls.Add(button1);
            applicationPanel.Controls.Add(CloseButton);
            applicationPanel.Controls.Add(redactionLabel);
            applicationPanel.Dock = DockStyle.Top;
            applicationPanel.Location = new Point(0, 0);
            applicationPanel.Name = "applicationPanel";
            applicationPanel.Size = new Size(468, 100);
            applicationPanel.TabIndex = 18;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(400, 32);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 27;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Transparent;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(12, 26);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 26;
            boyPhoto.TabStop = false;
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
            button1.Location = new Point(399, 0);
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
            CloseButton.Location = new Point(435, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 21;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // redactionLabel
            // 
            redactionLabel.AutoSize = true;
            redactionLabel.BackColor = Color.Transparent;
            redactionLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redactionLabel.ForeColor = Color.White;
            redactionLabel.Location = new Point(62, 26);
            redactionLabel.Name = "redactionLabel";
            redactionLabel.Size = new Size(346, 64);
            redactionLabel.TabIndex = 0;
            redactionLabel.Text = "Редактирование";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(35, 339);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(167, 24);
            numberLabel.TabIndex = 69;
            numberLabel.Text = "Номер телефона";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(136, 300);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 24);
            emailLabel.TabIndex = 68;
            emailLabel.Text = "Почта";
            // 
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Gray;
            numberField.Location = new Point(221, 339);
            numberField.Name = "numberField";
            numberField.Size = new Size(235, 24);
            numberField.TabIndex = 67;
            numberField.Text = "Номер телефона";
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.ForeColor = Color.Gray;
            emailField.Location = new Point(221, 301);
            emailField.Name = "emailField";
            emailField.Size = new Size(235, 24);
            emailField.TabIndex = 66;
            emailField.Text = "Почта";
            // 
            // sexField
            // 
            sexField.BackColor = Color.FromArgb(255, 230, 255);
            sexField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexField.ForeColor = Color.Gray;
            sexField.Location = new Point(221, 265);
            sexField.Name = "sexField";
            sexField.Size = new Size(235, 24);
            sexField.TabIndex = 65;
            sexField.Text = "Пол";
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Gray;
            cityField.Location = new Point(221, 229);
            cityField.Name = "cityField";
            cityField.Size = new Size(235, 24);
            cityField.TabIndex = 64;
            cityField.Text = "Город";
            // 
            // birhdayField
            // 
            birhdayField.BackColor = Color.FromArgb(255, 230, 255);
            birhdayField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birhdayField.ForeColor = Color.Gray;
            birhdayField.Location = new Point(221, 193);
            birhdayField.Name = "birhdayField";
            birhdayField.Size = new Size(235, 24);
            birhdayField.TabIndex = 63;
            birhdayField.Text = "Дата рождения";
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Gray;
            surnameField.Location = new Point(221, 158);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(235, 24);
            surnameField.TabIndex = 62;
            surnameField.Text = "Фамилия";
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Gray;
            nameField.Location = new Point(221, 123);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 61;
            nameField.Text = "Имя";
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel2.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel2.Controls.Add(redactionButton);
            gradientPanel2.Location = new Point(103, 425);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(264, 40);
            gradientPanel2.TabIndex = 60;
            // 
            // redactionButton
            // 
            redactionButton.BackColor = Color.Transparent;
            redactionButton.BackgroundImageLayout = ImageLayout.None;
            redactionButton.FlatAppearance.BorderSize = 0;
            redactionButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            redactionButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            redactionButton.FlatStyle = FlatStyle.Flat;
            redactionButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redactionButton.ForeColor = Color.White;
            redactionButton.Location = new Point(0, 0);
            redactionButton.Name = "redactionButton";
            redactionButton.Size = new Size(264, 40);
            redactionButton.TabIndex = 3;
            redactionButton.Text = "Редактировать";
            redactionButton.UseVisualStyleBackColor = false;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(153, 264);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(49, 24);
            sexLabel.TabIndex = 59;
            sexLabel.Text = "Пол";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(138, 228);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 58;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(153, 123);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 57;
            nameLabel.Text = "Имя";
            // 
            // birhdayLabel
            // 
            birhdayLabel.AutoSize = true;
            birhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birhdayLabel.Location = new Point(53, 193);
            birhdayLabel.Name = "birhdayLabel";
            birhdayLabel.Size = new Size(151, 24);
            birhdayLabel.TabIndex = 56;
            birhdayLabel.Text = "Дата рождения";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(103, 158);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 55;
            surnameLabel.Text = "Фамилия";
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(468, 477);
            Controls.Add(numberLabel);
            Controls.Add(emailLabel);
            Controls.Add(numberField);
            Controls.Add(emailField);
            Controls.Add(sexField);
            Controls.Add(cityField);
            Controls.Add(birhdayField);
            Controls.Add(surnameField);
            Controls.Add(nameField);
            Controls.Add(gradientPanel2);
            Controls.Add(sexLabel);
            Controls.Add(cityLabel);
            Controls.Add(nameLabel);
            Controls.Add(birhdayLabel);
            Controls.Add(surnameLabel);
            Controls.Add(applicationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditingForm";
            Text = "EditingForm";
            applicationPanel.ResumeLayout(false);
            applicationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel applicationPanel;
        private Button button1;
        private Button CloseButton;
        private Label redactionLabel;
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
        private Button redactionButton;
        private Label sexLabel;
        private Label cityLabel;
        private Label nameLabel;
        private Label birhdayLabel;
        private Label surnameLabel;
        private PictureBox boyPhoto;
        private PictureBox girlPhoto;
    }
}