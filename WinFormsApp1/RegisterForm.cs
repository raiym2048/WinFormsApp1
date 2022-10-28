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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            nameArea.Text = "Enter name";
            nameArea.ForeColor = Color.Gray;

            surnameArea.Text = "Enter surename";
            surnameArea.ForeColor = Color.Gray;

            EmailArea.Text = "Enter email";
            EmailArea.ForeColor = Color.Gray;

            PassArea.Text = "Enter password";
            PassArea.ForeColor = Color.Gray;


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.White;
        }

        Point lastPoint;
       

       

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (nameArea.Text == "Enter name")
            {
                MessageBox.Show("Enter Name!");
                return;
            }if (surnameArea.Text == "Enter surename")
            {
                MessageBox.Show("Enter surename!");
                return;
            }

            if (isUserExists())
            {
                return;
            }
                
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `email`, `password`, `name`, `surname`) VALUES (NULL, @login, @password, @name, @surename);", dB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = EmailArea.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PassArea.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameArea.Text;
            command.Parameters.Add("@surename", MySqlDbType.VarChar).Value = surnameArea.Text;
            

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("acc was created!");
                this.Hide();
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();
                
            }
                
            else
                MessageBox.Show("acc wasn't created!");

            dB.closeConnection();

        }

        public Boolean isUserExists()
        {
            /*String loginUser = EmailArea.Text;
            String passwordUser = PassArea.Text;*/

            DB dB = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE email = @uL", dB.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = EmailArea.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This acc is also created!");
                return true;
            }
            
            return false;
        }

        private void nameArea_Enter(object sender, EventArgs e)
        {
            if(nameArea.Text == "Enter name")
            {
                nameArea.Text = "";
                nameArea.ForeColor = Color.Black;

            }
            
        }

        private void nameArea_Leave(object sender, EventArgs e)
        {
            if (nameArea.Text == "")
            {
                nameArea.Text = "Enter name";
                nameArea.ForeColor = Color.Gray;
            }
                
        }

        private void surnameArea_Enter(object sender, EventArgs e)
        {
            if (surnameArea.Text == "Enter surename")
            {
                surnameArea.Text = "";
                surnameArea.ForeColor = Color.Black;

            }
        }

        private void surnameArea_Leave(object sender, EventArgs e)
        {
            if (surnameArea.Text == "")
            {
                surnameArea.Text = "Enter surename";
                surnameArea.ForeColor = Color.Gray;
            }
        }

        private void EmailArea_Enter(object sender, EventArgs e)
        {
            if (EmailArea.Text == "Enter email")
            {
                EmailArea.Text = "";
                EmailArea.ForeColor = Color.Black;

            }
        }

        private void EmailArea_Leave(object sender, EventArgs e)
        {
            if (EmailArea.Text == "")
            {
                EmailArea.Text = "Enter email";
                EmailArea.ForeColor = Color.Gray;
            }
        }

        private void PassArea_Enter(object sender, EventArgs e)
        {
            
            if (PassArea.Text == "Enter password")
            {
                PassArea.Text = "";
                PassArea.ForeColor = Color.Black;
                PassArea.Multiline = false;

            }
        }

        private void PassArea_Leave(object sender, EventArgs e)
        {
            if (PassArea.Text == "")
            {
                PassArea.Text = "Enter password";
                PassArea.ForeColor = Color.Gray;
                PassArea.Multiline = true;
                
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }
    }
}
