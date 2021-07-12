
namespace SerialCommunication__Serial_Port
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_1stClose = new System.Windows.Forms.Button();
            this.button_1stOpen = new System.Windows.Forms.Button();
            this.progressBar_1stStatusBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_1stEndLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_1stBaudeRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_1stComPort = new System.Windows.Forms.ComboBox();
            this.button_1stButtonSend = new System.Windows.Forms.Button();
            this.textBox_txtTextSent = new System.Windows.Forms.TextBox();
            this.richTextBox_1stTextReceiver = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_2ndClose = new System.Windows.Forms.Button();
            this.button_2ndOpen = new System.Windows.Forms.Button();
            this.progressBar_2ndStatusBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_2ndEndLine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_2ndBaudeRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_2ndComPort = new System.Windows.Forms.ComboBox();
            this.button_2ndButtonSend = new System.Windows.Forms.Button();
            this.textBox_2ndTextSent = new System.Windows.Forms.TextBox();
            this.richTextBox_2ndTextReceiver = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(784, 610);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_1stClose);
            this.groupBox1.Controls.Add(this.button_1stOpen);
            this.groupBox1.Controls.Add(this.progressBar_1stStatusBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_1stEndLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_1stBaudeRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_1stComPort);
            this.groupBox1.Controls.Add(this.button_1stButtonSend);
            this.groupBox1.Controls.Add(this.textBox_txtTextSent);
            this.groupBox1.Controls.Add(this.richTextBox_1stTextReceiver);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(770, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1st COM PORT";
            // 
            // button_1stClose
            // 
            this.button_1stClose.Location = new System.Drawing.Point(581, 253);
            this.button_1stClose.Name = "button_1stClose";
            this.button_1stClose.Size = new System.Drawing.Size(75, 25);
            this.button_1stClose.TabIndex = 11;
            this.button_1stClose.Text = "Close";
            this.button_1stClose.UseVisualStyleBackColor = true;
            this.button_1stClose.Click += new System.EventHandler(this.button_1stClose_Click);
            // 
            // button_1stOpen
            // 
            this.button_1stOpen.Location = new System.Drawing.Point(502, 253);
            this.button_1stOpen.Name = "button_1stOpen";
            this.button_1stOpen.Size = new System.Drawing.Size(75, 25);
            this.button_1stOpen.TabIndex = 10;
            this.button_1stOpen.Text = "Open";
            this.button_1stOpen.UseVisualStyleBackColor = true;
            this.button_1stOpen.Click += new System.EventHandler(this.button_1stOpen_Click);
            // 
            // progressBar_1stStatusBar
            // 
            this.progressBar_1stStatusBar.Location = new System.Drawing.Point(662, 253);
            this.progressBar_1stStatusBar.Name = "progressBar_1stStatusBar";
            this.progressBar_1stStatusBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar_1stStatusBar.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "END LINE :";
            // 
            // comboBox_1stEndLine
            // 
            this.comboBox_1stEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_1stEndLine.FormattingEnabled = true;
            this.comboBox_1stEndLine.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.comboBox_1stEndLine.Location = new System.Drawing.Point(407, 253);
            this.comboBox_1stEndLine.Name = "comboBox_1stEndLine";
            this.comboBox_1stEndLine.Size = new System.Drawing.Size(85, 25);
            this.comboBox_1stEndLine.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "BAUDE RATE :";
            // 
            // comboBox_1stBaudeRate
            // 
            this.comboBox_1stBaudeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_1stBaudeRate.FormattingEnabled = true;
            this.comboBox_1stBaudeRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_1stBaudeRate.Location = new System.Drawing.Point(261, 253);
            this.comboBox_1stBaudeRate.Name = "comboBox_1stBaudeRate";
            this.comboBox_1stBaudeRate.Size = new System.Drawing.Size(65, 25);
            this.comboBox_1stBaudeRate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT :";
            // 
            // comboBox_1stComPort
            // 
            this.comboBox_1stComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_1stComPort.FormattingEnabled = true;
            this.comboBox_1stComPort.Location = new System.Drawing.Point(89, 253);
            this.comboBox_1stComPort.Name = "comboBox_1stComPort";
            this.comboBox_1stComPort.Size = new System.Drawing.Size(65, 25);
            this.comboBox_1stComPort.TabIndex = 2;
            // 
            // button_1stButtonSend
            // 
            this.button_1stButtonSend.Location = new System.Drawing.Point(690, 26);
            this.button_1stButtonSend.Name = "button_1stButtonSend";
            this.button_1stButtonSend.Size = new System.Drawing.Size(75, 25);
            this.button_1stButtonSend.TabIndex = 4;
            this.button_1stButtonSend.Text = "Send";
            this.button_1stButtonSend.UseVisualStyleBackColor = true;
            this.button_1stButtonSend.Click += new System.EventHandler(this.button_1stButtonSend_Click);
            // 
            // textBox_txtTextSent
            // 
            this.textBox_txtTextSent.Location = new System.Drawing.Point(3, 26);
            this.textBox_txtTextSent.Name = "textBox_txtTextSent";
            this.textBox_txtTextSent.Size = new System.Drawing.Size(681, 25);
            this.textBox_txtTextSent.TabIndex = 1;
            // 
            // richTextBox_1stTextReceiver
            // 
            this.richTextBox_1stTextReceiver.Location = new System.Drawing.Point(3, 57);
            this.richTextBox_1stTextReceiver.Name = "richTextBox_1stTextReceiver";
            this.richTextBox_1stTextReceiver.Size = new System.Drawing.Size(764, 183);
            this.richTextBox_1stTextReceiver.TabIndex = 3;
            this.richTextBox_1stTextReceiver.Text = "";
            this.richTextBox_1stTextReceiver.TextChanged += new System.EventHandler(this.richTextBox_1stTextReceiver_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_2ndClose);
            this.groupBox2.Controls.Add(this.button_2ndOpen);
            this.groupBox2.Controls.Add(this.progressBar_2ndStatusBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_2ndEndLine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_2ndBaudeRate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox_2ndComPort);
            this.groupBox2.Controls.Add(this.button_2ndButtonSend);
            this.groupBox2.Controls.Add(this.textBox_2ndTextSent);
            this.groupBox2.Controls.Add(this.richTextBox_2ndTextReceiver);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(770, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2nd COM PORT";
            // 
            // button_2ndClose
            // 
            this.button_2ndClose.Location = new System.Drawing.Point(581, 253);
            this.button_2ndClose.Name = "button_2ndClose";
            this.button_2ndClose.Size = new System.Drawing.Size(75, 25);
            this.button_2ndClose.TabIndex = 11;
            this.button_2ndClose.Text = "Close";
            this.button_2ndClose.UseVisualStyleBackColor = true;
            this.button_2ndClose.Click += new System.EventHandler(this.button_2ndClose_Click);
            // 
            // button_2ndOpen
            // 
            this.button_2ndOpen.Location = new System.Drawing.Point(502, 253);
            this.button_2ndOpen.Name = "button_2ndOpen";
            this.button_2ndOpen.Size = new System.Drawing.Size(75, 25);
            this.button_2ndOpen.TabIndex = 10;
            this.button_2ndOpen.Text = "Open";
            this.button_2ndOpen.UseVisualStyleBackColor = true;
            this.button_2ndOpen.Click += new System.EventHandler(this.button_2ndOpen_Click);
            // 
            // progressBar_2ndStatusBar
            // 
            this.progressBar_2ndStatusBar.Location = new System.Drawing.Point(662, 253);
            this.progressBar_2ndStatusBar.Name = "progressBar_2ndStatusBar";
            this.progressBar_2ndStatusBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar_2ndStatusBar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "END LINE :";
            // 
            // comboBox_2ndEndLine
            // 
            this.comboBox_2ndEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_2ndEndLine.FormattingEnabled = true;
            this.comboBox_2ndEndLine.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.comboBox_2ndEndLine.Location = new System.Drawing.Point(407, 253);
            this.comboBox_2ndEndLine.Name = "comboBox_2ndEndLine";
            this.comboBox_2ndEndLine.Size = new System.Drawing.Size(85, 25);
            this.comboBox_2ndEndLine.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "BAUDE RATE :";
            // 
            // comboBox_2ndBaudeRate
            // 
            this.comboBox_2ndBaudeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_2ndBaudeRate.FormattingEnabled = true;
            this.comboBox_2ndBaudeRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_2ndBaudeRate.Location = new System.Drawing.Point(261, 253);
            this.comboBox_2ndBaudeRate.Name = "comboBox_2ndBaudeRate";
            this.comboBox_2ndBaudeRate.Size = new System.Drawing.Size(65, 25);
            this.comboBox_2ndBaudeRate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "COM PORT :";
            // 
            // comboBox_2ndComPort
            // 
            this.comboBox_2ndComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_2ndComPort.FormattingEnabled = true;
            this.comboBox_2ndComPort.Location = new System.Drawing.Point(89, 253);
            this.comboBox_2ndComPort.Name = "comboBox_2ndComPort";
            this.comboBox_2ndComPort.Size = new System.Drawing.Size(65, 25);
            this.comboBox_2ndComPort.TabIndex = 2;
            // 
            // button_2ndButtonSend
            // 
            this.button_2ndButtonSend.Location = new System.Drawing.Point(690, 26);
            this.button_2ndButtonSend.Name = "button_2ndButtonSend";
            this.button_2ndButtonSend.Size = new System.Drawing.Size(75, 25);
            this.button_2ndButtonSend.TabIndex = 4;
            this.button_2ndButtonSend.Text = "Send";
            this.button_2ndButtonSend.UseVisualStyleBackColor = true;
            this.button_2ndButtonSend.Click += new System.EventHandler(this.button_2ndButtonSend_Click);
            // 
            // textBox_2ndTextSent
            // 
            this.textBox_2ndTextSent.Location = new System.Drawing.Point(3, 26);
            this.textBox_2ndTextSent.Name = "textBox_2ndTextSent";
            this.textBox_2ndTextSent.Size = new System.Drawing.Size(681, 25);
            this.textBox_2ndTextSent.TabIndex = 1;
            // 
            // richTextBox_2ndTextReceiver
            // 
            this.richTextBox_2ndTextReceiver.Location = new System.Drawing.Point(3, 57);
            this.richTextBox_2ndTextReceiver.Name = "richTextBox_2ndTextReceiver";
            this.richTextBox_2ndTextReceiver.Size = new System.Drawing.Size(764, 183);
            this.richTextBox_2ndTextReceiver.TabIndex = 3;
            this.richTextBox_2ndTextReceiver.Text = "";
            this.richTextBox_2ndTextReceiver.TextChanged += new System.EventHandler(this.richTextBox_2ndTextReceiver_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 610);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Ports | 2 IN 1 PORTS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_1stClose;
        private System.Windows.Forms.Button button_1stOpen;
        private System.Windows.Forms.ProgressBar progressBar_1stStatusBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_1stEndLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_1stBaudeRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_1stComPort;
        private System.Windows.Forms.Button button_1stButtonSend;
        private System.Windows.Forms.TextBox textBox_txtTextSent;
        private System.Windows.Forms.RichTextBox richTextBox_1stTextReceiver;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_2ndClose;
        private System.Windows.Forms.Button button_2ndOpen;
        private System.Windows.Forms.ProgressBar progressBar_2ndStatusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_2ndEndLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_2ndBaudeRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_2ndComPort;
        private System.Windows.Forms.Button button_2ndButtonSend;
        private System.Windows.Forms.TextBox textBox_2ndTextSent;
        private System.Windows.Forms.RichTextBox richTextBox_2ndTextReceiver;
        private System.IO.Ports.SerialPort serialPort2;
    }
}