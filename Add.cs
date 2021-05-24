using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundry_Dry_Cleaning
{
    public partial class Add : Form
    {
        
       
        public Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients f = new Clients();
            f.Update();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SELECT ("id клиента", "Фамилия", "Имя", "Отчество", "Адрес", "Телефон" FROM "dbo"."Физ лица";
        }
    }
}

