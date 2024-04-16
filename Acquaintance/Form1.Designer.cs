namespace Acquaintance
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            entryPanel = new GradientPanel();
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            gradientPanel2 = new GradientPanel();
            loginButton = new Button();
            loginField = new TextBox();
            loginLabel = new Label();
            passwordField = new TextBox();
            passwondLabel = new Label();
            comboBox1 = new ComboBox();
            registrButton = new Button();
            choice = new ComboBox();
            label1 = new Label();
            entryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // entryPanel
            // 
            entryPanel.Angle = 0F;
            entryPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            entryPanel.ColorTop = Color.FromArgb(141, 11, 173);
            entryPanel.Controls.Add(girlPhoto);
            entryPanel.Controls.Add(boyPhoto);
            entryPanel.Controls.Add(CollapseButton);
            entryPanel.Controls.Add(CloseButton);
            entryPanel.Controls.Add(entryLabel);
            entryPanel.Dock = DockStyle.Top;
            entryPanel.Location = new Point(0, 0);
            entryPanel.Name = "entryPanel";
            entryPanel.Size = new Size(419, 100);
            entryPanel.TabIndex = 0;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(295, 33);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 25;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Transparent;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(67, 33);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 24;
            boyPhoto.TabStop = false;
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
            CollapseButton.Location = new Point(350, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 23;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
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
            CloseButton.Click += CloseButton_Click;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = Color.Transparent;
            entryLabel.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = Color.White;
            entryLabel.Location = new Point(136, 16);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(150, 84);
            entryLabel.TabIndex = 0;
            entryLabel.Text = "Вход";
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel2.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel2.Controls.Add(loginButton);
            gradientPanel2.Location = new Point(96, 344);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(224, 58);
            gradientPanel2.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(0, 0);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(224, 58);
            loginButton.TabIndex = 2;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(45, 212);
            loginField.Name = "loginField";
            loginField.Size = new Size(326, 32);
            loginField.TabIndex = 2;
            loginField.Text = "Введите логин...";
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(50, 183);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 26);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Логин";
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.Location = new Point(45, 290);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(326, 32);
            passwordField.TabIndex = 4;
            passwordField.Text = "Введите пароль...";
            passwordField.Enter += passwordFields_Enter;
            passwordField.Leave += passwordFields_Leave;
            // 
            // passwondLabel
            // 
            passwondLabel.AutoSize = true;
            passwondLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwondLabel.Location = new Point(45, 261);
            passwondLabel.Name = "passwondLabel";
            passwondLabel.Size = new Size(93, 26);
            passwondLabel.TabIndex = 5;
            passwondLabel.Text = "Пароль";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(295, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 6;
            // 
            // registrButton
            // 
            registrButton.BackColor = Color.Transparent;
            registrButton.FlatAppearance.BorderSize = 0;
            registrButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            registrButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            registrButton.FlatStyle = FlatStyle.Flat;
            registrButton.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registrButton.ForeColor = Color.Purple;
            registrButton.Location = new Point(114, 417);
            registrButton.Name = "registrButton";
            registrButton.Size = new Size(185, 30);
            registrButton.TabIndex = 8;
            registrButton.Text = "Зарегистрироваться";
            registrButton.UseVisualStyleBackColor = false;
            // 
            // choice
            // 
            choice.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            choice.FormattingEnabled = true;
            choice.Items.AddRange(new object[] { "Пользователь", "Администратор " });
            choice.Location = new Point(45, 135);
            choice.Name = "choice";
            choice.Size = new Size(326, 31);
            choice.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(50, 106);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 10;
            label1.Text = "Войти как";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 459);
            Controls.Add(label1);
            Controls.Add(choice);
            Controls.Add(registrButton);
            Controls.Add(comboBox1);
            Controls.Add(passwondLabel);
            Controls.Add(passwordField);
            Controls.Add(loginLabel);
            Controls.Add(loginField);
            Controls.Add(gradientPanel2);
            Controls.Add(entryPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            entryPanel.ResumeLayout(false);
            entryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel entryPanel;
        private Label entryLabel;
        private GradientPanel gradientPanel2;
        private Button loginButton;
        private Button CollapseButton;
        private Button CloseButton;
        private TextBox loginField;
        private Label loginLabel;
        private TextBox passwordField;
        private Label passwondLabel;
        private ComboBox comboBox1;
        private Button registrButton;
        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private ComboBox choice;
        private Label label1;
    }
}
