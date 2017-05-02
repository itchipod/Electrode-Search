using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrode_Search
{
    public partial class Electrode_Details : Form
    {
        public Electrode_Details()
        {
            InitializeComponent();
            txt_application.SelectedText = null;
        }

        private void Electrode_Details_Load(object sender, EventArgs e)
        {
            gettempdb();
        }

        private void gettempdb()
        {
            //string strProvider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\JGalve\Documents\Visual Studio 2015\Projects\Electrode Search\Electrode Search\Electrodes.accdb";
            using (var connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\Electrodes.accdb;Persist Security Info=True"))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "select * from TempElectrode";
                //command.Parameters.AddWithValue("electrodename", txt_electrode.Text);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_electrode.Text = reader["electrodename"].ToString();
                    txt_application.Text = reader["application"].ToString();
                    txt_descr.Text = reader["tempdescription"].ToString();
                    txt_type.Text = reader["temptype"].ToString();
                    txt_current.Text = reader["tempcurrent"].ToString();
                    //txtPrice.Text = reader["Price"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
