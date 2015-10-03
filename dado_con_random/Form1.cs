using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dado_con_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTO_JUGAR_Click(object sender, EventArgs e)
        {
            dado x = new dado();
            LBL_DADO.Text = x.jugar().ToString();
        }
    }
}
