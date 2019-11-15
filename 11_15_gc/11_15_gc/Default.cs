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

namespace _11_15_gc
{


    public partial class Default : Form
    {
        SqlConnection conn;
        public Default()
        {
            InitializeComponent(); // VK-PC\Csaba
            conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tura;"); // XDDDDD
            Fillit();
        }

        private void Fillit()
        {
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM turazo;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {


                dtg_adat.Rows.Add(r[0],r[1],r[2],r[3],r[4]);
            }

            conn.Close();
        }

        private void Bt_szemely_Click(object sender, EventArgs e)
        {
            conn.Open();
            var adapter = new SqlDataAdapter();

            //adapter.InsertCommand = new SqlCommand("INSERT INTO turazo (vezeteknev, keresztnev, varos, telefon) " +
            //  $"VALUES ('')");


            //MessageBox.Show("Az adatok rögzítése megtörtént!"); 
            //!!NEM IDE

            conn.Close();
            //!

            var valami = new FormNewMember();
            valami.Show();

        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            dtg_adat.Refresh();
        }

        private void dtg_adat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ROW HEADER VISIBLE = FALSE
            //dtg_adat.RowHeadersVisible = false;

            //SELECTION MODE
            //dtg_adat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var valami = new FormMemberDetail();
            valami.Show();

        }
    }
}
