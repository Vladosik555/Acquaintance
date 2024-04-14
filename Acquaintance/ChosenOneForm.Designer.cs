namespace Acquaintance
{
    partial class ChosenOneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChosenOneForm));
            appicationPanel = new GradientPanel();
            button1 = new Button();
            CloseButton = new Button();
            RegistrLabel = new Label();
            list = new ListView();
            boyPhoto = new PictureBox();
            girlPhoto = new PictureBox();
            appicationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            SuspendLayout();
            // 
            // appicationPanel
            // 
            appicationPanel.Angle = 0F;
            appicationPanel.ColorBottom = Color.FromArgb(245, 8, 243);
            appicationPanel.ColorTop = Color.FromArgb(141, 11, 173);
            appicationPanel.Controls.Add(girlPhoto);
            appicationPanel.Controls.Add(boyPhoto);
            appicationPanel.Controls.Add(button1);
            appicationPanel.Controls.Add(CloseButton);
            appicationPanel.Controls.Add(RegistrLabel);
            appicationPanel.Dock = DockStyle.Top;
            appicationPanel.Location = new Point(0, 0);
            appicationPanel.Name = "appicationPanel";
            appicationPanel.Size = new Size(418, 96);
            appicationPanel.TabIndex = 18;
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
            button1.Location = new Point(350, -4);
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
            RegistrLabel.Location = new Point(99, 26);
            RegistrLabel.Name = "RegistrLabel";
            RegistrLabel.Size = new Size(228, 64);
            RegistrLabel.TabIndex = 0;
            RegistrLabel.Text = "Избранное";
            // 
            // list
            // 
            list.Location = new Point(1, 93);
            list.Name = "list";
            list.Size = new Size(417, 356);
            list.TabIndex = 19;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.List;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Transparent;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(30, 26);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 26;
            boyPhoto.TabStop = false;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Transparent;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(322, 26);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 27;
            girlPhoto.TabStop = false;
            // 
            // ChosenOneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(list);
            Controls.Add(appicationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChosenOneForm";
            Text = "ChosenOneForm";
            appicationPanel.ResumeLayout(false);
            appicationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel appicationPanel;
        private Button button1;
        private Button CloseButton;
        private Label RegistrLabel;
        private ListView list;
        private PictureBox boyPhoto;
        private PictureBox girlPhoto;
    }
}