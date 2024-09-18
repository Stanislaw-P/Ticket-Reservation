using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Reservation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string townFirst = comboBox1.Text;
            string townSecond = comboBox2.Text;
            string dateTime = dateTimePicker1.Text;
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        
    }
}
