namespace WinFormsApp1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.surnameArea = new System.Windows.Forms.TextBox();
            this.PassArea = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameArea = new System.Windows.Forms.TextBox();
            this.EmailArea = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(this.surnameArea);
            this.panel1.Controls.Add(this.PassArea);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.nameArea);
            this.panel1.Controls.Add(this.EmailArea);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnterButton.Location = new System.Drawing.Point(279, 302);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(218, 33);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Register!";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // surnameArea
            // 
            this.surnameArea.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameArea.Location = new System.Drawing.Point(456, 132);
            this.surnameArea.Multiline = true;
            this.surnameArea.Name = "surnameArea";
            this.surnameArea.Size = new System.Drawing.Size(218, 43);
            this.surnameArea.TabIndex = 4;
            this.surnameArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameArea.UseSystemPasswordChar = true;
            this.surnameArea.Enter += new System.EventHandler(this.surnameArea_Enter);
            this.surnameArea.Leave += new System.EventHandler(this.surnameArea_Leave);
            // 
            // PassArea
            // 
            this.PassArea.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassArea.Location = new System.Drawing.Point(456, 195);
            this.PassArea.Multiline = true;
            this.PassArea.Name = "PassArea";
            this.PassArea.Size = new System.Drawing.Size(218, 38);
            this.PassArea.TabIndex = 4;
            this.PassArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassArea.UseSystemPasswordChar = true;
            this.PassArea.Enter += new System.EventHandler(this.PassArea_Enter);
            this.PassArea.Leave += new System.EventHandler(this.PassArea_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.cookie;
            this.pictureBox2.Location = new System.Drawing.Point(395, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // nameArea
            // 
            this.nameArea.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameArea.Location = new System.Drawing.Point(132, 137);
            this.nameArea.Multiline = true;
            this.nameArea.Name = "nameArea";
            this.nameArea.Size = new System.Drawing.Size(218, 38);
            this.nameArea.TabIndex = 2;
            this.nameArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameArea.Enter += new System.EventHandler(this.nameArea_Enter);
            this.nameArea.Leave += new System.EventHandler(this.nameArea_Leave);
            // 
            // EmailArea
            // 
            this.EmailArea.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailArea.Location = new System.Drawing.Point(132, 195);
            this.EmailArea.Multiline = true;
            this.EmailArea.Name = "EmailArea";
            this.EmailArea.Size = new System.Drawing.Size(218, 38);
            this.EmailArea.TabIndex = 2;
            this.EmailArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailArea.Enter += new System.EventHandler(this.EmailArea_Enter);
            this.EmailArea.Leave += new System.EventHandler(this.EmailArea_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.cookie;
            this.pictureBox1.Location = new System.Drawing.Point(71, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(730, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 33);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "x";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(599, 312);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 6;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button EnterButton;
        private TextBox PassArea;
        private PictureBox pictureBox2;
        private TextBox EmailArea;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label ExitButton;
        private TextBox surnameArea;
        private TextBox nameArea;
        private Button login;
    }
}