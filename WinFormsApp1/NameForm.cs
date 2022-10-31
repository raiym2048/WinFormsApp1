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
    public partial class NameForm : Form
    {
        public static bool logOut = false;


        

        public NameForm()
        {
            InitializeComponent();
            
            DB data = new DB();
            data.ClearLists();
            data.RefreshDatabase();

            CreateLabel(data.getCarId(), data.getCarName(), data.getBalance());
            
           
           
        }
        public void CreateLabel(List<string> cardID, List<string> cardName, List<string> blnc)
        {
            //MessageBox.Show(cardID[0].ToString());
            if (cardID.Count == 0)
                MessageBox.Show("List is null!");
            

            for (int i = 0; i < cardID.Count; i++)
            {
                /*if (cardID[i].Count()>1){
                    cardID.RemoveAt(i);
                    cardName.RemoveAt(i);
                    blnc.RemoveAt(i);
                }*/
                
                Label label = new Label();
                label.Text = cardID[i].ToString();
                label.Name = "lb";
                label.Location = new Point(100, 150 + (i * 50));
                panel1.Controls.Add(label);

                Label label3 = new Label();
                label3.Text = cardName[i].ToString();
                label3.Name = "lb";
                label3.Location = new Point(300, 150 + (i * 50));
                panel1.Controls.Add(label3);

                Label label2 = new Label();
                label2.Text = blnc[i].ToString();
                label2.Name = "lb";
                label2.Location = new Point(500, 150 + (i * 50));
                panel1.Controls.Add(label2);

                Button deleteButton = new Button();
                deleteButton.Text = "delete";
                deleteButton.Name = "dlb";
                deleteButton.Location = new Point(700, 150 + (i * 50));
                deleteButton.Click += new EventHandler(delete_Click);
                panel1.Controls.Add(deleteButton);



            }
        }

       /* private EventHandler delete_Click()
        {
            MessageBox.Show("delete!");
            throw new NotImplementedException();
        }*/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Me me = new Me();
            me.Show();
           

        }

        private void log_out_Click(object sender, EventArgs e)
        {

            /*foreach (Control ctrl in this.panel1.Controls)
            {
                // Check if control is of type label
                if (ctrl.GetType() == typeof(Label))
                {
                    // check the name of the label
                    if (ctrl.Name == "lb")
                    {
                        this.panel1.Controls.Remove(ctrl);
                    }
                }
            }*/
            DB dB = new DB();
            dB.ClearLists();

            this.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logOut = true;
            DB dB = new DB();
            dB.ClearLists();
            InitializeComponent();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("delete!");
        }

    }
}                    

