using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_1st_Sem_Gr12
{
    public partial class GetInfoForm : Form
    {
        public GetInfoForm(string strSeatNum, string strTime)
        {
            InitializeComponent();
            comboBox2.Text = strSeatNum;
            comboBox3.Text = strTime;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
