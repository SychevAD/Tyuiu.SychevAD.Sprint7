
namespace Tyuiu.SychevAD.Sprint7.Project.V2
{
    partial class FormHelpDevWin
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
            btnOpenBrowser = new Button();
            buttonCloseBackUnion = new Button();
            labelHelpDevWinInfo = new Label();
            groupBoxHelpDevWin = new GroupBox();
            groupBoxHelpDevWin.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenBrowser
            // 
            btnOpenBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOpenBrowser.BackColor = SystemColors.Info;
            btnOpenBrowser.FlatStyle = FlatStyle.Popup;
            btnOpenBrowser.ForeColor = SystemColors.ActiveCaptionText;
            btnOpenBrowser.Location = new Point(16, 29);
            btnOpenBrowser.Margin = new Padding(4, 5, 4, 5);
            btnOpenBrowser.Name = "btnOpenBrowser";
            btnOpenBrowser.Size = new Size(574, 74);
            btnOpenBrowser.TabIndex = 0;
            btnOpenBrowser.Text = "Связаться с нами";
            btnOpenBrowser.UseVisualStyleBackColor = false;
            btnOpenBrowser.Click += btnOpenBrowser_Click;
            // 
            // buttonCloseBackUnion
            // 
            buttonCloseBackUnion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCloseBackUnion.BackColor = SystemColors.Info;
            buttonCloseBackUnion.FlatStyle = FlatStyle.Popup;
            buttonCloseBackUnion.ForeColor = SystemColors.ActiveCaptionText;
            buttonCloseBackUnion.Location = new Point(16, 112);
            buttonCloseBackUnion.Margin = new Padding(4, 5, 4, 5);
            buttonCloseBackUnion.Name = "buttonCloseBackUnion";
            buttonCloseBackUnion.Size = new Size(574, 46);
            buttonCloseBackUnion.TabIndex = 1;
            buttonCloseBackUnion.Text = "Закрыть";
            buttonCloseBackUnion.UseVisualStyleBackColor = false;
            buttonCloseBackUnion.Click += buttonCloseBackUnion_SAD_Click;
            // 
            // labelHelpDevWinInfo
            // 
            labelHelpDevWinInfo.BackColor = SystemColors.Info;
            labelHelpDevWinInfo.Font = new Font("Sitka Banner", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelHelpDevWinInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelHelpDevWinInfo.Location = new Point(12, 14);
            labelHelpDevWinInfo.Margin = new Padding(4, 0, 4, 0);
            labelHelpDevWinInfo.Name = "labelHelpDevWinInfo";
            labelHelpDevWinInfo.Size = new Size(580, 248);
            labelHelpDevWinInfo.TabIndex = 2;
            labelHelpDevWinInfo.Text = "\r\n\r\nЕсли у вас возникли трудности с данным программным обеспечением,\r\nВы можете связаться с нашей службой поддержки\r\nНажав на кнопку \"Связаться с нами\"\r\n\r\n\r\n";
            labelHelpDevWinInfo.TextAlign = ContentAlignment.MiddleCenter;
            labelHelpDevWinInfo.Click += label1_Click;
            // 
            // groupBoxHelpDevWin
            // 
            groupBoxHelpDevWin.Controls.Add(btnOpenBrowser);
            groupBoxHelpDevWin.Controls.Add(buttonCloseBackUnion);
            groupBoxHelpDevWin.Dock = DockStyle.Bottom;
            groupBoxHelpDevWin.Location = new Point(0, 233);
            groupBoxHelpDevWin.Margin = new Padding(4, 5, 4, 5);
            groupBoxHelpDevWin.Name = "groupBoxHelpDevWin";
            groupBoxHelpDevWin.Padding = new Padding(4, 5, 4, 5);
            groupBoxHelpDevWin.Size = new Size(599, 182);
            groupBoxHelpDevWin.TabIndex = 3;
            groupBoxHelpDevWin.TabStop = false;
            // 
            // FormHelpDevWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(599, 415);
            Controls.Add(groupBoxHelpDevWin);
            Controls.Add(labelHelpDevWinInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(617, 462);
            MinimizeBox = false;
            MinimumSize = new Size(617, 462);
            Name = "FormHelpDevWin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обратная связь и поддержка ";
            Load += FormHelpDevWin_Load;
            groupBoxHelpDevWin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.Button buttonCloseBackUnion;
        private System.Windows.Forms.Label labelHelpDevWinInfo;
        private System.Windows.Forms.GroupBox groupBoxHelpDevWin;
    }
}