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
    public partial class DeletingObject : Form
    {
        Label c;
        public DeletingObject(Label cl)
        {
            InitializeComponent();
            c = cl;
            //MessageBox.Show(c.Text);
        }
        
        private void deleteLabels_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.RemoveLabel(c);
            MainPage nameForm = new MainPage();
            this.Hide();
            nameForm.Show();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            MainPage nameForm = new MainPage();
            this.Hide();
            nameForm.Show();
        }
    }
}
