using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_15_gc
{
    public partial class FormMemberDetail : Form
    {
        public FormMemberDetail()
        {
            InitializeComponent();
            //f2_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //f2_dtg.RowHeadersVisible = false;
        }

        private void f2_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //0. oszlop click event
            {
                MessageBox.Show("0. oszlop");
            }
            else if (e.ColumnIndex == 1) // ...wtf PRESS F
            {
                MessageBox.Show("1. oszlop");
            }
        }
    }
}
