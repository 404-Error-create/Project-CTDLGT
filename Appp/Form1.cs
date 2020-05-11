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
        }
    }
}
