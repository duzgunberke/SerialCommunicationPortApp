using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SerialCommunication__Serial_Port
{
    public partial class Form2 : Form
    {

        MySqlConnection myConnection;
        MySqlCommand myCommand;
        MySqlDataAdapter myDataAdapter;
        DataSet myDataSet;
        Form1 objForm1;

        private void RefreshAndShowDataOnDataGridView()
        {
            try
            {
                myConnection = new MySqlConnection("server=localhost; username=root; password=; port=3306; database=database01");
                myConnection.Open();

                myCommand = new MySqlCommand("SELECT * FROM `table01`", myConnection);
                myDataAdapter = new MySqlDataAdapter(myCommand);
                myDataSet = new DataSet();

                myDataAdapter.Fill(myDataSet,"Serial Data");
                dataGridView1.DataSource = myDataSet;
                dataGridView1.DataMember = "Serial Data";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Refresh();

                myConnection.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void EventFromForm1(object sender,Form1.UpdateDataEventArgs args)
        {
            RefreshAndShowDataOnDataGridView();
        }

        public Form2(Form1 obj)
        {
            InitializeComponent();
            objForm1 = obj;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshAndShowDataOnDataGridView();
            objForm1.UpdateDataEventHandler += EventFromForm1;
        }
    }
}
