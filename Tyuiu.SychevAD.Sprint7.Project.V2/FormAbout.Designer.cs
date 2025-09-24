namespace Tyuiu.SychevAD.Sprint7.Project.V2
{
    partial class FormAbout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_SAD = new Button();
            labelInfo_SAD = new Label();
            labelInfo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBoxAvatar_SAD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SAD).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_SAD
            // 
            buttonOK_SAD.BackColor = SystemColors.Info;
            buttonOK_SAD.FlatStyle = FlatStyle.Flat;
            buttonOK_SAD.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_SAD.ForeColor = Color.Black;
            buttonOK_SAD.Location = new Point(9, 198);
            buttonOK_SAD.Margin = new Padding(4, 5, 4, 5);
            buttonOK_SAD.Name = "buttonOK_SAD";
            buttonOK_SAD.Size = new Size(557, 51);
            buttonOK_SAD.TabIndex = 1;
            buttonOK_SAD.Text = "ОКЕЙ";
            buttonOK_SAD.UseVisualStyleBackColor = false;
            buttonOK_SAD.Click += buttonOK_SAD_Click;
            // 
            // labelInfo_SAD
            // 
            labelInfo_SAD.AutoSize = true;
            labelInfo_SAD.Location = new Point(181, 14);
            labelInfo_SAD.Margin = new Padding(4, 0, 4, 0);
            labelInfo_SAD.Name = "labelInfo_SAD";
            labelInfo_SAD.Size = new Size(0, 20);
            labelInfo_SAD.TabIndex = 3;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = SystemColors.Info;
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(151, 14);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(387, 180);
            labelInfo.TabIndex = 4;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBoxAvatar_SAD
            // 
            pictureBoxAvatar_SAD.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar_SAD.ErrorImage = null;
            pictureBoxAvatar_SAD.Image = (Image)resources.GetObject("pictureBoxAvatar_SAD.Image");
            pictureBoxAvatar_SAD.Location = new Point(9, 14);
            pictureBoxAvatar_SAD.Margin = new Padding(4, 5, 4, 5);
            pictureBoxAvatar_SAD.Name = "pictureBoxAvatar_SAD";
            pictureBoxAvatar_SAD.Size = new Size(133, 180);
            pictureBoxAvatar_SAD.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_SAD.TabIndex = 5;
            pictureBoxAvatar_SAD.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(573, 242);
            Controls.Add(pictureBoxAvatar_SAD);
            Controls.Add(labelInfo);
            Controls.Add(labelInfo_SAD);
            Controls.Add(buttonOK_SAD);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(591, 289);
            MinimizeBox = false;
            MinimumSize = new Size(591, 289);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prod. by Sychev ®";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SAD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonOK_SAD;
        private System.Windows.Forms.Label labelInfo_SAD;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAD;
    }
}