using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Dry_Cleaning
{
    public partial class UpdClients : Form
    {
        public UpdClients()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients f = new Clients();
            f.Show();
            Hide();
        }
    }
}
