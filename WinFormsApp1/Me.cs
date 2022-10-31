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
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Me : Form
    {
        public Me()
        {
            InitializeComponent();
        }
        public List<String> l = new List<String>();

        private void button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `cards` (`id`, `card_id`, `card_user`, `balance`) VALUES (@id, @card_id1, @card_user, @balance);", dB.getConnection());
            int idM = dB.getUsId();
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idM;
            command.Parameters.Add("@card_id1", MySqlDbType.VarChar).Value = card_id_in.Text;
            command.Parameters.Add("@card_user", MySqlDbType.VarChar).Value = card_user_in.Text;
            command.Parameters.Add("@balance", MySqlDbType.VarChar).Value = balance_in.Text;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                l.Add(card_id_in.Text);
                l.Add(card_user_in.Text);
                l.Add(balance_in.Text);

                MessageBox.Show("the card was created!");
                dB.ClearLists();
                this.Close();
                NameForm registrationForm = new NameForm();
                registrationForm.Show();
                InitializeComponent();

            }

            else
                MessageBox.Show("acc wasn't created!");

            dB.closeConnection();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
