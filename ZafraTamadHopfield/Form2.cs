using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZafraTamadHopfield
{
    public partial class Form2 : Form
    {
        public int scrambleLevel = 10;

        public Form2()
        {
            InitializeComponent();
        }
        private void scramblebtn_Click(object sender, EventArgs e)
        {
            scrambleLevel = Convert.ToInt32(scramblelevelbox.Value);
            this.Close();
        }
    }
}
