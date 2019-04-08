using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chemicalModel.Model;

namespace chemicalModel
{
    public partial class AuthView : Form
    {
        public AuthView()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthModel am = new AuthModel();
            string entry = am.Entry(login.Text, password.Text);
            //Убрал чтоб не мешало
            //if (entry != "")
            //{
            //    errorStr.Text = entry;
                
            //}
            Hide();
        }

        public void UserClosedForm()
        {

        }

        private void AuthView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason.ToString() == "UserClosing")
            {
                Application.Exit();
            }
            
        }
    }
}
