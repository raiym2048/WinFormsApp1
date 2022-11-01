namespace WinFormsApp1
{
    partial class DeletingObject
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.returnLabel = new System.Windows.Forms.Button();
            this.deleteLabels = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.returnLabel);
            this.MainPanel.Controls.Add(this.deleteLabels);
            this.MainPanel.Location = new System.Drawing.Point(100, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 100);
            this.MainPanel.TabIndex = 0;
            // 
            // returnLabel
            // 
            this.returnLabel.Location = new System.Drawing.Point(122, 39);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(75, 23);
            this.returnLabel.TabIndex = 1;
            this.returnLabel.Text = "Back";
            this.returnLabel.UseVisualStyleBackColor = true;
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // deleteLabels
            // 
            this.deleteLabels.Location = new System.Drawing.Point(3, 39);
            this.deleteLabels.Name = "deleteLabels";
            this.deleteLabels.Size = new System.Drawing.Size(75, 23);
            this.deleteLabels.TabIndex = 0;
            this.deleteLabels.Text = "delete";
            this.deleteLabels.UseVisualStyleBackColor = true;
            this.deleteLabels.Click += new System.EventHandler(this.deleteLabels_Click);
            // 
            // DeletingObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 161);
            this.Controls.Add(this.MainPanel);
            this.Name = "DeletingObject";
            this.Text = "DeletingObject";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Button returnLabel;
        private Button deleteLabels;
    }
}