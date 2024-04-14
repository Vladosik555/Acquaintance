namespace Acquaintance
{
    partial class RegistrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrForm));
            passwordLabel2 = new Label();
            password2Field = new TextBox();
            passwordLabel = new Label();
            passwordField = new TextBox();
            FurtherPanel = new GradientPanel();
            FurtherButton = new Button();
            RegistrPanel = new GradientPanel();
            girlPhoto = new PictureBox();
            BoyPhoto = new PictureBox();
            CollapseBotton = new Button();
            CloseButton = new Button();
            RegistrLabel = new Label();
            LoginText = new TextBox();
            loginLabel = new Label();
            FurtherPanel.SuspendLayout();
            RegistrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoyPhoto).BeginInit();
            SuspendLayout();
            // 
            // passwordLabel2
            // 
            passwordLabel2.AutoSize = true;
            passwordLabel2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel2.Location = new Point(45, 286);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new Size(219, 26);
            passwordLabel2.TabIndex = 14;
            passwordLabel2.Text = "Повторный пароль";
            // 
            // password2Field
            // 
            password2Field.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password2Field.Location = new Point(45, 315);
            password2Field.Name = "password2Field";
            password2Field.Size = new Size(326, 32);
            password2Field.TabIndex = 13;
            password2Field.Text = "Введите повторно пароль...";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(45, 212);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 26);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.Location = new Point(45, 241);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(326, 32);
            passwordField.TabIndex = 11;
            passwordField.Text = "Введите пароль...";
            // 
            // FurtherPanel
            // 
            FurtherPanel.Angle = 0F;
            FurtherPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            FurtherPanel.ColorTop = Color.FromArgb(141, 11, 173);
            FurtherPanel.Controls.Add(FurtherButton);
            FurtherPanel.Location = new Point(96, 366);
            FurtherPanel.Name = "FurtherPanel";
            FurtherPanel.Size = new Size(224, 62);
            FurtherPanel.TabIndex = 10;
            // 
            // FurtherButton
            // 
            FurtherButton.BackColor = Color.Transparent;
            FurtherButton.BackgroundImageLayout = ImageLayout.None;
            FurtherButton.FlatAppearance.BorderSize = 0;
            FurtherButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            FurtherButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            FurtherButton.FlatStyle = FlatStyle.Flat;
            FurtherButton.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FurtherButton.ForeColor = Color.White;
            FurtherButton.Location = new Point(0, 0);
            FurtherButton.Name = "FurtherButton";
            FurtherButton.Size = new Size(224, 62);
            FurtherButton.TabIndex = 2;
            FurtherButton.Text = "Далее";
            FurtherButton.UseVisualStyleBackColor = false;
            // 
            // RegistrPanel
            // 
            RegistrPanel.Angle = 0F;
            RegistrPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            RegistrPanel.ColorTop = Color.FromArgb(141, 11, 173);
            RegistrPanel.Controls.Add(girlPhoto);
            RegistrPanel.Controls.Add(BoyPhoto);
            RegistrPanel.Controls.Add(CollapseBotton);
            RegistrPanel.Controls.Add(CloseButton);
            RegistrPanel.Controls.Add(RegistrLabel);
            RegistrPanel.Dock = DockStyle.Top;
            RegistrPanel.Location = new Point(0, 0);
            RegistrPanel.Name = "RegistrPanel";
            RegistrPanel.Size = new Size(420, 100);
            RegistrPanel.TabIndex = 9;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(345, 26);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 26;
            girlPhoto.TabStop = false;
            // 
            // BoyPhoto
            // 
            BoyPhoto.BackColor = Color.Transparent;
            BoyPhoto.Image = (Image)resources.GetObject("BoyPhoto.Image");
            BoyPhoto.Location = new Point(12, 26);
            BoyPhoto.Name = "BoyPhoto";
            BoyPhoto.Size = new Size(63, 58);
            BoyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            BoyPhoto.TabIndex = 25;
            BoyPhoto.TabStop = false;
            // 
            // CollapseBotton
            // 
            CollapseBotton.Anchor = AnchorStyles.Bottom;
            CollapseBotton.BackColor = Color.Transparent;
            CollapseBotton.FlatAppearance.BorderSize = 0;
            CollapseBotton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CollapseBotton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CollapseBotton.FlatStyle = FlatStyle.Flat;
            CollapseBotton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseBotton.ForeColor = Color.White;
            CollapseBotton.Location = new Point(349, 0);
            CollapseBotton.Name = "CollapseBotton";
            CollapseBotton.Size = new Size(35, 23);
            CollapseBotton.TabIndex = 24;
            CollapseBotton.Text = "—";
            CollapseBotton.UseVisualStyleBackColor = false;
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
            // LoginText
            // 
            LoginText.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginText.Location = new Point(45, 165);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(326, 32);
            LoginText.TabIndex = 15;
            LoginText.Text = "Введите логин...";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(45, 136);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 26);
            loginLabel.TabIndex = 16;
            loginLabel.Text = "Логин";
            // 
            // RegistrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 450);
            Controls.Add(loginLabel);
            Controls.Add(LoginText);
            Controls.Add(passwordLabel2);
            Controls.Add(password2Field);
            Controls.Add(passwordLabel);
            Controls.Add(passwordField);
            Controls.Add(FurtherPanel);
            Controls.Add(RegistrPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrForm";
            Text = "RegistrForm";
            FurtherPanel.ResumeLayout(false);
            RegistrPanel.ResumeLayout(false);
            RegistrPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoyPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label passwordLabel2;
        private TextBox password2Field;
        private Label passwordLabel;
        private TextBox passwordField;
        private GradientPanel FurtherPanel;
        private Button FurtherButton;
        private GradientPanel RegistrPanel;
        private Button CloseButton;
        private Label RegistrLabel;
        private Button CollapseBotton;
        private TextBox LoginText;
        private Label loginLabel;
        private PictureBox BoyPhoto;
        private PictureBox girlPhoto;
    }
}