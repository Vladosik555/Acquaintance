namespace Acquaintance
{
    partial class RecommenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecommenForm));
            gradientPanel1 = new GradientPanel();
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            button1 = new Button();
            CloseButton = new Button();
            RegistrLabel = new Label();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.ColorBottom = Color.FromArgb(245, 8, 243);
            gradientPanel1.ColorTop = Color.FromArgb(141, 11, 173);
            gradientPanel1.Controls.Add(girlPhoto);
            gradientPanel1.Controls.Add(boyPhoto);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(CloseButton);
            gradientPanel1.Controls.Add(RegistrLabel);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(420, 96);
            gradientPanel1.TabIndex = 19;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(357, 26);
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
            boyPhoto.Location = new Point(3, 26);
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
            button1.Location = new Point(353, 0);
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
            RegistrLabel.Location = new Point(63, 26);
            RegistrLabel.Name = "RegistrLabel";
            RegistrLabel.Size = new Size(297, 64);
            RegistrLabel.TabIndex = 0;
            RegistrLabel.Text = "Рекомендации";
            // 
            // RecommenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecommenForm";
            Text = "RecommenForm";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button button1;
        private Button CloseButton;
        private Label RegistrLabel;
    }
}