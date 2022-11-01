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
    public partial class CardAdd : Form
    {
        public CardAdd()
        {
            InitializeComponent();
        }
        public List<String> l = new List<String>();

        private void Save_Click(object sender, EventArgs e)
        {
            if (card_user_in.Text.Length > 2 && card_user_in.Text != "" &&
                card_id_in.Text.Length > 2 && card_id_in.Text != "" &&
                balance_in.Text.Length > 0 && balance_in.Text != "")
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
                    MainPage registrationForm = new MainPage();
                    registrationForm.Show();
                    InitializeComponent();

                }

                else
                    MessageBox.Show("acc wasn't created!");

                dB.closeConnection();
            }
            else
            {
                MessageBox.Show("Fill the blanks!");
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage main = new MainPage();
            main.Show();
        }
    }

    public class CardAddDiagram
    {
    }
}
