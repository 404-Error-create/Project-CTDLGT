using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appp
{
    public partial class Frm_SignIn : Form
    {
        public Frm_SignIn()
        {
            InitializeComponent();
        }

        private void Frm_SignIn_Load(object sender, EventArgs e)
        {
            ptb_Back.Parent = ptb_BackGround;
            ptb_Back.BackColor = Color.Transparent;
            ptb_SignIn.Parent = ptb_BackGround;
            ptb_SignIn.BackColor = Color.Transparent;
            ptb_ADmin.Parent = ptb_BackGround;
            ptb_SignUp.BackColor = Color.Transparent;
            ptb_SignUp.Parent = ptb_BackGround;
            ptb_ADmin.BackColor = Color.Transparent;
            lb_User.Parent = ptb_BackGround;
            lb_User.BackColor = Color.Transparent;
            lb_PassWord.Parent = ptb_BackGround;
            lb_PassWord.BackColor = Color.Transparent;
            lb_chose.Parent = ptb_BackGround;
            lb_chose.BackColor = Color.Transparent;
        }

        private void ptb_SignUp_Click(object sender, EventArgs e)
        {
            Frm_SignUp frm_SignIn = new Frm_SignUp();
            this.Hide();
            frm_SignIn.ShowDialog();
            this.Show();
        }

        private void ptb_SignIn_Click(object sender, EventArgs e)
        {
            frm_main frm_SignIn = new frm_main();
            this.Hide();
            frm_SignIn.ShowDialog();
            this.Show();
        }
    }
}
