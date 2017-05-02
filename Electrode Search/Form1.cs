using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private OleDbConnection myconn;
        public Form1()
        {
            InitializeComponent();
            myconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Electrodes.accdb;Persist Security Info=True");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("electrodename LIKE '%{0}%'", tb_electrode.Text);
            this.dataGridView1.Sort(this.dataGridView1.Columns["Priority"], ListSortDirection.Descending);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectdb();
            this.dataGridView1.Sort(this.dataGridView1.Columns["electrodename"], ListSortDirection.Ascending);
            dataGridView1.Rows[0].Selected = true;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void connectdb()
        {
            string strProvider = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Electrodes.accdb;Persist Security Info=True";
            string strSql = "Select * from ElectrodeDetails";
            using (OleDbConnection conn = new OleDbConnection(strProvider))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(strSql, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns["Priority"].Visible = false;
                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["electrodename"].HeaderText = "Electrode Name";
                    dataGridView1.Columns["application"].HeaderText = "Application";

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var y = 0;
            String arrayapp = tb_application.Text;
            string[] tagArray = arrayapp.Split(new char[] { ',', ' ' },
                                StringSplitOptions.RemoveEmptyEntries);
            int arraycount = tagArray.Length;
            if (arraycount == 1)
            {
                foreach (var f in tagArray)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("application LIKE '%{0}%'", tagArray[0]);
                    y++;
                }
            }
            if (arraycount == 2)
            {
                foreach (var f in tagArray)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("application LIKE '%{0}%' AND application LIKE '%{1}%'", tagArray[0], tagArray[1]);
                    y++;
                }
            }
            if (arraycount == 3)
            {
                foreach (var f in tagArray)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("application LIKE '%{0}%' AND application LIKE '%{1}%' AND application LIKE '%{2}%'", tagArray[0], tagArray[1], tagArray[2]);
                    y++;
                }
            }
            if (arraycount == 4)
            {
                foreach (var f in tagArray)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("application LIKE '%{0}%' AND application LIKE '%{1}%' AND application LIKE '%{2}%' AND application LIKE '%{3}%'", tagArray[0], tagArray[1], tagArray[2], tagArray[3]);
                    y++;
                }
            }
            if (arraycount == 5)
            {
                foreach (var f in tagArray)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("application LIKE '%{0}%' AND application LIKE '%{1}%' AND application LIKE '%{2}%' AND application LIKE '%{3}%' AND application LIKE '%{4}%'", tagArray[0], tagArray[1], tagArray[2], tagArray[3], tagArray[4]);
                    y++;
                }
            }

        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            deletetempdb();
            inserttempdb();
            Electrode_Details ed = new Electrode_Details();
            if (Application.OpenForms[ed.Name] == null)
                ed.Show();
            else
                Application.OpenForms[ed.Name].Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void deletetempdb()
        {
            try {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE from TempElectrode";
                cmd.Connection = myconn;
                myconn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void inserttempdb()
        {
            try {
                String electrodename = dataGridView1.SelectedCells[1].Value.ToString();
                String application = dataGridView1.SelectedCells[2].Value.ToString();
                String description = dataGridView1.SelectedCells[3].Value.ToString();
                String type = dataGridView1.SelectedCells[4].Value.ToString();
                String current = dataGridView1.SelectedCells[5].Value.ToString();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO TempElectrode (electrodename, application, tempdescription, temptype, tempcurrent) Values (@electrodename, @application, @description, @type, @current)";
                cmd.Parameters.AddWithValue("@electrodename", electrodename);
                cmd.Parameters.AddWithValue("@application", application);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@current", current);
                cmd.Connection = myconn;
                //myconn.Open();
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "No selection, please select a row");
            }
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tb_application.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            tb_electrode.Text = "";
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.SelectedRows != null)
                    dataGridView1_DoubleClick(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Up)
            {
                
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.SelectedCells != null)
                    dataGridView1_DoubleClick(this, new EventArgs());
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.SelectedRows != null)
                    dataGridView1_DoubleClick(this, new EventArgs());
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

            }
               
        }


    }
}
