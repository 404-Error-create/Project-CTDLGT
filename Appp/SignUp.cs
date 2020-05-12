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
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            ptb_Back.Parent = ptb_BackGround;
            ptb_Back.BackColor = Color.Transparent;
            ptb_SignUp.Parent = ptb_BackGround;
            ptb_SignUp.BackColor = Color.Transparent;
            lb_User.Parent = ptb_BackGround;
            lb_User.BackColor = Color.Transparent;
            lb_PassWord.Parent = ptb_BackGround;
            lb_PassWord.BackColor = Color.Transparent;
            lb_Email.Parent = ptb_BackGround;
            lb_Email.BackColor = Color.Transparent;
        }

        private void ptb_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
