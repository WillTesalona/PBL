using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PBL_1st_Sem_Gr12
{
    public partial class SeatForm : Form
    {
        public SeatForm()
        {
            InitializeComponent();
        }
        string cinema = "1";
        string time = "11:00am";
        private void buttonClick(Button btn)
        {
            string seatNum = btn.ToString();
            btn.BackColor = Color.Red;
            GetInfoForm aForm = new GetInfoForm(cinema, time);
            aForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //GetInfoForm frm = new GetInfoForm(cinema);
            buttonClick(button1);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
