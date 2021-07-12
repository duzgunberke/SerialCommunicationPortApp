using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using MySql.Data.MySqlClient;

namespace SerialCommunication__Serial_Port
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendWith;
        string DataIN;
        int dataINLength;
        int[] dataInDec;

        StreamWriter objStreamWriter;
        //string pathfile = @"C:\Users\90507\source\repos\SerialCommunication_ Serial_Port\SerialCommunication_ Serial_Port\_My Source File\SerialData.txt";
        string pathfile;
        bool state_AppendText = true;

        MySqlConnection myConnection;
        MySqlCommand myCommand;

        #region My Own Method
        private void SaveDataToTxtFile()
        {
            if (saveToTxtFileToolStripMenuItem.Checked)
            {
                try
                {
                    objStreamWriter = new StreamWriter(pathfile, state_AppendText);
                    if (toolStripComboBox_writeLineOrwriteText.Text == "WriteLine")
                    {
                        objStreamWriter.WriteLine(DataIN);
                    }
                    else if (toolStripComboBox_writeLineOrwriteText.Text == "Write")
                    {
                        objStreamWriter.Write(DataIN + " ");
                    }

                    objStreamWriter.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

        }

        private void SaveDataToMySqlDatabase()
        {
            if (saveToMySQLToolStripMenuItem.Checked)
            {
                try
                {
                    myConnection = new MySqlConnection("server=localhost; username=root; password=; port=3306; database=database01");
                    myConnection.Open();

                    myCommand = new MySqlCommand(string.Format("INSERT INTO `table01` VALUES('{0}')", DataIN), myConnection);
                    myCommand.ExecuteNonQuery();

                    myConnection.Close();

                    RefreshDataGridViewForm2();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }
        #region Custom EventHandler
        public delegate void UpdateDelegate(object sender, UpdateDataEventArgs args);

        public event UpdateDelegate UpdateDataEventHandler;

        public class UpdateDataEventArgs : EventArgs
        {

        }
        protected void RefreshDataGridViewForm2()
        {
            UpdateDataEventArgs args = new UpdateDataEventArgs();
            UpdateDataEventHandler.Invoke(this, args);
        }

        #endregion

        #region RX Data Format
        private string RxDataFormat(int[] dataInput)
        {
            string strOut = "";
            if (toolStripComboBox4.Text == "Hex")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 16) + "\t";
                }

            }
            else if (toolStripComboBox4.Text == "Decimal")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element) + "\t";
                }

            }
            else if (toolStripComboBox4.Text == "Binary")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToString(element, 2) + "\t";
                }

            }
            else if (toolStripComboBox4.Text == "Char")
            {
                foreach (int element in dataInput)
                {
                    strOut += Convert.ToChar(element);
                }

            }
            return strOut;
        }
        #endregion

        #region TX Data Format

        private void TxDataFormat()
        {
            if (toolStripComboBox_TxDataFormat.Text == "Char")
            {
                //Metin kutusundaki verileri seri port üzerinden gönderin
                serialPort1.Write(tBoxDataOut.Text);

                //Gönderilen verilerin uzunluğunu hesaplayın ve ardından gösterin
                int dataOUTLength = tBoxDataOut.TextLength;
                lbDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
            }
            else
            {
                //Yerel Değişken Bildirisi
                string dataOutBuffer;
                int countComma = 0;
                string[] dataPrepareToSend;
                byte[] dataToSend;

                try
                {
                    //Metin kutusundaki veri paketini bir değişkene taşıyın
                    dataOutBuffer = tBoxDataOut.Text;

                    //Veri paketinde ne kadar virgül (,) noktalama işareti olduğunu sayın
                    foreach (char c in dataOutBuffer)
                    {
                        if (c == ',')
                        {
                            countComma++;
                        }
                    }

                    //Sayıma dayalı uzunlukta bir boyutlu dizi (dize veri türü) oluşturun
                    //countCommand
                    dataPrepareToSend = new string[countComma];

                    //DataOutBuffer'daki verileri ayrıştırma ve virgül noktalama işaretlerine göre dataPrepareToSend dizisine kaydetme
                    countComma = 0; //Değeri 0'a sıfırla
                    foreach (char c in dataOutBuffer)
                    {
                        if (c!= ',')
                        {
                            //dataPrepareToSend dizisine , tarihi ekleyin
                            dataPrepareToSend[countComma] += c;
                        }
                        else
                        {
                           // Veri paketinde virgül bulunursa, countComma değişkenini artırın.CountComma, dataPrepareToSend dizisinin dizinini belirlemek için kullanıyor
                            countComma++;
                            //dataPrepareToSend boyutuna countComma sayısı varsa foreach işlemini durdurun
                            if (countComma == dataPrepareToSend.GetLength(0)) { break; }
                        }
                    }

                    //dataPrepareToSend boyutunu temel alan uzunlukta tek boyutlu dizi (bayt veri türü) oluşturun
                    dataToSend = new byte[dataPrepareToSend.Length];

                    if (toolStripComboBox_TxDataFormat.Text == "Hex")
                    {
                        //Dize dizisindeki (dataPrepareToSend) verileri bayt dizisine (dataToSend) dönüştürün 
                        for (int i = 0; i < dataPrepareToSend.Length; i++)
                        {
                            dataToSend[i] = Convert.ToByte(dataPrepareToSend[i], 16);
                            //convert string to an 8-bit unsigned integer with the specified base      number 
                            //Value 16 mean Hexa
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Binary")
                    {
                        //Convert data in string array (dataPrepareToSend) into byte array(dataToSend) 
                        for (int i = 0; i < dataPrepareToSend.Length; i++)
                        {
                            dataToSend[i] = Convert.ToByte(dataPrepareToSend[i], 2);
                            //dizeyi belirtilen taban numarasıyla 8 bitlik işaretsiz bir tam sayıya dönüştürün 
                            //Value 2  Binary anlamında
                        }
                    }
                    else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
                    {
                        //Dize dizisindeki (dataPrepareToSend) verileri bayt dizisine (dataToSend) dönüştürün 
                        for (int i = 0; i < dataPrepareToSend.Length; i++)
                        {
                            dataToSend[i] = Convert.ToByte(dataPrepareToSend[i], 10);
                            //dizeyi belirtilen taban numarasıyla 8 bitlik işaretsiz bir tam sayıya dönüştürün 
                            //Value 10 Decimal anlamında
                        }
                    }
                    //Seri bağlantı noktasına belirli sayıda bayt gönder
                    serialPort1.Write(dataToSend, 0, dataToSend.Length);

                    //Gönderilen verinin uzunluğunu hesaplayın ve ardından gösterin
                    lbDataOutLength.Text = string.Format("{0:00}", dataToSend.Length);
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message); 
                }

            }
        }
        
        private void TxtSendData()
        {
            if (serialPort1.IsOpen)
            {
               // dataOUT = tBoxDataOut.Text;
                if (sendWith == "None")
                {
                    // serialPort1.Write(dataOUT);
                    TxDataFormat();
                }
                //seçim sonucuna gore portalara yazdırıyoruz
                else if (sendWith == @"Both (\r\n)")
                {
                    // serialPort1.Write(dataOUT + "\r\n");
                    TxDataFormat();
                    serialPort1.Write("\r\n");
                }
                else if (sendWith == @"New Line (\n)")
                {
                    //serialPort1.Write(dataOUT + "\n");
                    TxDataFormat();
                    serialPort1.Write("\n");
                }
                else if (sendWith == @"Carriage Return (\r)")
                {
                    //serialPort1.Write(dataOUT + "\r");
                    TxDataFormat();
                    serialPort1.Write("\r");
                }

            }
            if (clearToolStripMenuItem.Checked)
            {
                if (tBoxDataOut.Text != "")
                {
                    tBoxDataOut.Text = "";
                }
            }
        }
        
        
        #endregion
              
        #endregion

        #region GUI Method

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = true;
            sendWith = @"Both (\r\n)";
            toolStripComboBox3.Text = "BOTTOM";

            toolStripComboBox1.Text = "Add to Old Data";
            toolStripComboBox2.Text = @"Both (\r\n)";

            bilgiMesaji("Transmitter anahtar kelimeleri ne anlama geliyor ? ", " New Line = \\n \n Carriage Return = \\r \n Both = \\r + \\n \n\n VE DAHA FAZLA BİLGİ İÇİN SORU İŞARETİNE TIKLAYINIZ :)", label7);

            toolStripComboBox_appendOrOverwriteText.Text = "Append Text";
            toolStripComboBox_writeLineOrwriteText.Text = "WriteLine";

            pathfile = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            pathfile += @"\_My Source File\SerialData.txt";

            saveToTxtFileToolStripMenuItem.Checked = false;
            saveToMySQLToolStripMenuItem.Checked = false;

            toolStripComboBox4.Text = "Char";

            toolStripComboBox_TxDataFormat.Text = "Char";
            this.toolStripComboBox_TxDataFormat.ComboBox.SelectionChangeCommitted += new System.EventHandler(this.toolStripComboBox_TxDataFormat_SelectionChangeCommitted);

        }

        İnfo fr;

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fr = new İnfo();
            //fr.Show();
            System.Diagnostics.Process.Start("file:///C:/Users/90507/Desktop/110/portfolio-responsive-complete-master/index.html");
        }

        public ToolTip bilgiMesaji(string baslik, string aciklama, Control nesne)
        {
            ToolTip bilgi = new ToolTip();
            bilgi.Active = true;
            bilgi.ToolTipTitle = baslik;
            bilgi.ToolTipIcon = ToolTipIcon.Info;
            bilgi.UseFading = true;
            bilgi.UseAnimation = true;
            bilgi.IsBalloon = true; //!
            bilgi.ShowAlways = true;
            bilgi.AutoPopDelay = 20000;
            bilgi.ReshowDelay = 5000;
            bilgi.InitialDelay = 0;
            bilgi.BackColor = Color.White;
            bilgi.ForeColor = Color.DarkBlue;
            bilgi.SetToolTip(nesne, aciklama);
            return bilgi;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;


                lbStatusCom.Text = "ON";
                lbStatusCom.BackColor = Color.WhiteSmoke;
            }
            catch (Exception)
            {
                MessageBox.Show("PORT BAĞLAYINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbStatusCom.Text = "OFF";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                lbStatusCom.Text = "OFF";
                lbStatusCom.BackColor = Color.Red;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            TxtSendData();
        }

        private void toolStripComboBox2_DropDownClosed(object sender, EventArgs e)
        {
            //None
            //Both
            //New Line
            //Carriage Return
            if (toolStripComboBox2.Text == "None")
            {
                sendWith = "None";
            }
            else if (toolStripComboBox2.Text == @"Both (\r\n)")
            {
                sendWith = @"Both (\r\n)";
            }
            else if (toolStripComboBox2.Text == @"New Line (\n)")
            {
                sendWith = @"New Line (\n)";
            }
            else if (toolStripComboBox2.Text == @"Carriage Return (\r)")
            {
                sendWith = @"Carriage Return (\r)";
            }

        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true; //Aktif et DTR Serial Port1
                MessageBox.Show("DTR Aktif", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.DtrEnable = false; //İnaktif et DTR Serial Port1
            }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRtsEnable.Checked)
            {
                serialPort1.RtsEnable = true;  //Aktif et RTS Serial Port1
                MessageBox.Show("RTS Aktif", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                serialPort1.RtsEnable = false; //İnaktif et RTS Serial Port1
            }
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.doSomething();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void doSomething()
        {
            TxtSendData();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // DataIN = serialPort1.ReadExisting();

            List<int> dataBuffer = new List<int>();

            while (serialPort1.BytesToRead > 0)
            {
                try
                {
                    dataBuffer.Add(serialPort1.ReadByte());
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }

            dataINLength = dataBuffer.Count();
            dataInDec = new int[dataINLength];
            dataInDec = dataBuffer.ToArray();

            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            // int dataINLength = DataIN.Length;

            DataIN = RxDataFormat(dataInDec);
            lbDataInLength.Text = string.Format("{0:00}", dataINLength);
            if (toolStripComboBox1.Text == "Always Update") //anlık gırdıgınız karakterı gsoterır
            {
                tBoxDataIN.Text = DataIN;
            }
            else if (toolStripComboBox1.Text == "Add to Old Data")// com baglantısından sonra gırılen her gırdıyı gosterır
            {
                if (toolStripComboBox3.Text == "TOP")
                {
                    tBoxDataIN.Text = tBoxDataIN.Text.Insert(0, DataIN);
                }
                else if (toolStripComboBox3.Text == "BOTTOM")
                {
                    tBoxDataIN.Text += DataIN;
                }
            }

            SaveDataToTxtFile();
            SaveDataToMySqlDatabase();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t       =====Created by Dzgn===== \n\n Bu proje Süleyman Hocanın tavsiyeleri ve yol göstericiliği ile  2021 yılının Haziran ayında yapılmıştır.", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbStatusCom_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox11.Width = panel1.Width - 237;
            groupBox11.Height = panel1.Height - 75;

            tBoxDataIN.Height = panel1.Height - 121;
        }

        private void lbDataInLength_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transmitter Button\n****************************\n New Line = \\n  \n Carriage Return = \\r \n Both = \\r + \\n \n****************************", "Information");
        }

        private void toolStripComboBox_appendOrOverwriteText_DropDownClosed(object sender, EventArgs e)
        {
            if (toolStripComboBox_appendOrOverwriteText.Text == "Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;

            }
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2(this);
            objForm2.Show();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3(this);
            objForm3.Show();
            //this.Hide();
        }
        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox3.Text == "BOTTOM")
            {
                tBoxDataIN.SelectionStart = tBoxDataIN.Text.Length;
                tBoxDataIN.ScrollToCaret();
            }
        }

        private void cBoxCOMPORT_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.Clear();
            cBoxCOMPORT.Items.AddRange(ports);
        }

        private void in1PortsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tBoxDataOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (toolStripComboBox_TxDataFormat.Text == "Hex")
            {
                //In Hex format, the textbox only accepts the 0-9 key and A-F key
                //The lower case will convert to the upper case so both can enter on the textbox
                char uppercase = char.ToUpper(c);

                //if it is not the numbers key presed not the backspace key pressed, not the delete key
                // pressed, not a comma key pressed, not the A-F key pressed

                if (!char.IsDigit(uppercase) && uppercase != 8 && uppercase != 46 && uppercase != ',' && !(uppercase >= 65 && uppercase <= 70))
                {
                    //Cancel the KeyPress Event
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Decimal")
            {
                //In Decimal format, the textbox only accepts the numbers key, that is 0-9 


                //if it is not the numbers key presed not the backspace key pressed, not the delete key
                // pressed, not a comma key pressed

                if (!char.IsDigit(c) && c != 8 && c != 46 && c != ',')
                {
                    //Cancel the KeyPress Event
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Binary")
            {
                //In Binary form, the textbox only take 1 and 0 key


                //if it is not the one (1) key pressed, not the zero (0) not the backspace key pressed, not the delete key
                // pressed, not a comma key pressed

                if (c != 49 && c != 48 && c != 8 && c != 46 && c != ',')
                {
                    //Cancel the KeyPress Event
                    e.Handled = true;
                }
            }
            else if (toolStripComboBox_TxDataFormat.Text == "Char")
            {
                //Do nothing
            }
        }

        private void toolStripComboBox_TxDataFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Every time selected different Tx data format, then delete all contents in the textbox data out 
            tBoxDataOut.Clear();

            //Show a message every time I selected different Tx Data Format
            string message = "Char veri biçimini kullanmıyorsanız, her bayt verisinden sonra virgül (,) ekleyin. Aksi takdirde, bayt verileri yok sayılacaktır. \n" + "Örnek :\n\t 255, -> Bir bayt veri \n" +
                "\t 255,128,140, -> İki ve ya daha fazla veri \n" +
                "\t 120,144,189 -> 189'u virgül içermediğini görmezden gelecek(,)";
            MessageBox.Show(message, "UYARI", MessageBoxButtons.OK);
        }

        #endregion
    }

}
