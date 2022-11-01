using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainPage : Form
    {   

        public MainPage()
        {
            InitializeComponent();
            
            DB data = new DB();
            data.ClearLists();
            data.RefreshDatabase();

            CreateLabel(data.getCarId(), data.getCarName(), data.getBalance());
           
        }
        public void CreateLabel(List<string> cardID, List<string> cardName, List<string> blnc)
        {
            if (cardID.Count == 0)
                MessageBox.Show("List is null!");
            

            for (int i = 0; i < cardID.Count; i++)
            {
                
                Label label = new Label();
                label.Text = cardID[i].ToString();
                label.Name = i.ToString();
                label.Location = new Point(100, 150 + (i * 50));
                MainPanel.Controls.Add(label);

                Label label3 = new Label();
                label3.Text = cardName[i].ToString();
                label3.Name = i.ToString();
                label3.Location = new Point(300, 150 + (i * 50));
                MainPanel.Controls.Add(label3);

                Label label2 = new Label();
                label2.Text = blnc[i].ToString();
                label2.Name = i.ToString();
                label2.Location = new Point(500, 150 + (i * 50));
                MainPanel.Controls.Add(label2);

                Button deleteButton = new Button();
                deleteButton.Text = "delete";
                deleteButton.Name = i.ToString();
                deleteButton.Location = new Point(700, 150 + (i * 50));
                deleteButton.Click += new EventHandler(delete_Click);
                MainPanel.Controls.Add(deleteButton);



            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardAdd me = new CardAdd();
            me.Show();
           

        }

        private void log_out_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.ClearLists();

            this.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            
        }
        Boolean b = true;
        private void delete_Click(object sender, EventArgs e)
        {
            
            foreach (Control card_id in MainPanel.Controls)
            {
                if (card_id is Label && card_id.Name == (sender as Button).Name)
                {
                    if (b)
                    {
                        b = false;
                        DeletingObject deletingObject = new DeletingObject((Label)card_id);
                        this.Hide();
                        deletingObject.Show();
                    }
                        
                }
            }

        }
      

    }
}                    

