using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalSinif
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTest testPanel = new frmTest();
            if (testPanel.ShowDialog() != DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
