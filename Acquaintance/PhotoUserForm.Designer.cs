namespace Acquaintance
{
    partial class PhotoUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoUserForm));
            Photo = new PictureBox();
            panel1 = new Panel();
            BirhdayField = new Label();
            BirhdayLabel = new Label();
            nameField = new Label();
            nameLabel = new Label();
            panel2 = new Panel();
            likeAccount = new PictureBox();
            nextAccount = new PictureBox();
            gradientPanel6 = new GradientPanel();
            button5 = new Button();
            gradientPanel1 = new GradientPanel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)likeAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextAccount).BeginInit();
            gradientPanel6.SuspendLayout();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Photo
            // 
            Photo.Image = (Image)resources.GetObject("Photo.Image");
            Photo.Location = new Point(0, 1);
            Photo.Name = "Photo";
            Photo.Size = new Size(428, 292);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 2;
            Photo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BirhdayField);
            panel1.Controls.Add(BirhdayLabel);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(0, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 95);
            panel1.TabIndex = 3;
            // 
            // BirhdayField
            // 
            BirhdayField.BackColor = Color.FromArgb(255, 230, 255);
            BirhdayField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirhdayField.ForeColor = Color.Gray;
            BirhdayField.Location = new Point(130, 60);
            BirhdayField.Name = "BirhdayField";
            BirhdayField.Size = new Size(235, 24);
            BirhdayField.TabIndex = 49;
            BirhdayField.Text = "Возраст";
            // 
            // BirhdayLabel
            // 
            BirhdayLabel.AutoSize = true;
            BirhdayLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BirhdayLabel.Location = new Point(12, 58);
            BirhdayLabel.Name = "BirhdayLabel";
            BirhdayLabel.Size = new Size(103, 26);
            BirhdayLabel.TabIndex = 48;
            BirhdayLabel.Text = "Возраст ";
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Gray;
            nameField.Location = new Point(130, 19);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 47;
            nameField.Text = "Имя";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(33, 17);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(60, 26);
            nameLabel.TabIndex = 46;
            nameLabel.Text = "Имя";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(gradientPanel1);
            panel2.Controls.Add(gradientPanel6);
            panel2.Controls.Add(likeAccount);
            panel2.Controls.Add(nextAccount);
            panel2.Location = new Point(0, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 103);
            panel2.TabIndex = 4;
            // 
            // likeAccount
            // 
            likeAccount.Image = (Image)resources.GetObject("likeAccount.Image");
            likeAccount.Location = new Point(12, 12);
            likeAccount.Name = "likeAccount";
            likeAccount.Size = new Size(87, 72);
            likeAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount.TabIndex = 2;
            likeAccount.TabStop = false;
            // 
            // nextAccount
            // 
            nextAccount.Image = (Image)resources.GetObject("nextAccount.Image");
            nextAccount.Location = new Point(320, 12);
            nextAccount.Name = "nextAccount";
            nextAccount.Size = new Size(98, 72);
            nextAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            nextAccount.TabIndex = 1;
            nextAccount.TabStop = false;
            // 
            // gradientPanel6
            // 
            gradientPanel6.Angle = 0F;
            gradientPanel6.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel6.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel6.Controls.Add(button5);
            gradientPanel6.Location = new Point(165, 53);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(98, 31);
            gradientPanel6.TabIndex = 49;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(98, 31);
            button5.TabIndex = 4;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = false;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel1.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Location = new Point(105, 12);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(209, 35);
            gradientPanel1.TabIndex = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(209, 35);
            button1.TabIndex = 4;
            button1.Text = "Изменить фильтры";
            button1.UseVisualStyleBackColor = false;
            // 
            // PhotoUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 487);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Photo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhotoUserForm";
            Text = "PhotoUserForm";
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)likeAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextAccount).EndInit();
            gradientPanel6.ResumeLayout(false);
            gradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Photo;
        private Panel panel1;
        private Panel panel2;
        private Label nameField;
        private Label nameLabel;
        private Label BirhdayField;
        private Label BirhdayLabel;
        private PictureBox nextAccount;
        private PictureBox likeAccount;
        private GradientPanel gradientPanel6;
        private Button button5;
        private GradientPanel gradientPanel1;
        private Button button1;
    }
}