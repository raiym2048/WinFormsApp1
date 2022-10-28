namespace WinFormsApp1
{
    partial class Me
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.moneySave = new System.Windows.Forms.RadioButton();
            this.moneyTake = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.balance_in = new System.Windows.Forms.TextBox();
            this.card_user_in = new System.Windows.Forms.TextBox();
            this.card_id_in = new System.Windows.Forms.TextBox();
            this.CardUser = new System.Windows.Forms.Label();
            this.CardId = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.moneySave);
            this.panel1.Controls.Add(this.moneyTake);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Controls.Add(this.balance_in);
            this.panel1.Controls.Add(this.card_user_in);
            this.panel1.Controls.Add(this.card_id_in);
            this.panel1.Controls.Add(this.CardUser);
            this.panel1.Controls.Add(this.CardId);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(23, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 364);
            this.panel1.TabIndex = 0;
            // 
            // moneySave
            // 
            this.moneySave.AutoSize = true;
            this.moneySave.Checked = true;
            this.moneySave.Location = new System.Drawing.Point(505, 127);
            this.moneySave.Name = "moneySave";
            this.moneySave.Size = new System.Drawing.Size(89, 19);
            this.moneySave.TabIndex = 11;
            this.moneySave.TabStop = true;
            this.moneySave.Text = "Save Money";
            this.moneySave.UseVisualStyleBackColor = true;
            // 
            // moneyTake
            // 
            this.moneyTake.AutoSize = true;
            this.moneyTake.Location = new System.Drawing.Point(505, 63);
            this.moneyTake.Name = "moneyTake";
            this.moneyTake.Size = new System.Drawing.Size(88, 19);
            this.moneyTake.TabIndex = 10;
            this.moneyTake.Text = "Take Money";
            this.moneyTake.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(112, 192);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(48, 15);
            this.balance.TabIndex = 6;
            this.balance.Text = "balance";
            // 
            // balance_in
            // 
            this.balance_in.Location = new System.Drawing.Point(209, 184);
            this.balance_in.Name = "balance_in";
            this.balance_in.Size = new System.Drawing.Size(207, 23);
            this.balance_in.TabIndex = 5;
            this.balance_in.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // card_user_in
            // 
            this.card_user_in.Location = new System.Drawing.Point(209, 127);
            this.card_user_in.Name = "card_user_in";
            this.card_user_in.Size = new System.Drawing.Size(207, 23);
            this.card_user_in.TabIndex = 4;
            // 
            // card_id_in
            // 
            this.card_id_in.Location = new System.Drawing.Point(209, 59);
            this.card_id_in.Name = "card_id_in";
            this.card_id_in.Size = new System.Drawing.Size(207, 23);
            this.card_id_in.TabIndex = 3;
            // 
            // CardUser
            // 
            this.CardUser.AutoSize = true;
            this.CardUser.Location = new System.Drawing.Point(102, 135);
            this.CardUser.Name = "CardUser";
            this.CardUser.Size = new System.Drawing.Size(58, 15);
            this.CardUser.TabIndex = 2;
            this.CardUser.Text = "Card User";
            // 
            // CardId
            // 
            this.CardId.AutoSize = true;
            this.CardId.Location = new System.Drawing.Point(102, 63);
            this.CardId.Name = "CardId";
            this.CardId.Size = new System.Drawing.Size(46, 15);
            this.CardId.TabIndex = 1;
            this.CardId.Text = "Card ID";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(341, 265);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Me
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Me";
            this.Text = "Me";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button Save;
        private Label balance;
        private TextBox balance_in;
        private TextBox card_user_in;
        private TextBox card_id_in;
        private Label CardUser;
        private Label CardId;
        private Button button1;
        private RadioButton moneySave;
        private RadioButton moneyTake;
    }
}