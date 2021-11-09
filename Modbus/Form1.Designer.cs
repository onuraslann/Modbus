
namespace Modbus
{
    partial class form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaglantıAc = new System.Windows.Forms.Button();
            this.btnBaglantıKapat = new System.Windows.Forms.Button();
            this.txtServerIPAdress = new System.Windows.Forms.TextBox();
            this.lblBaglantıDurumu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrModbusTcpIP = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModbusServer0 = new System.Windows.Forms.TextBox();
            this.txtModbusServer1 = new System.Windows.Forms.TextBox();
            this.txtModbusServer2 = new System.Windows.Forms.TextBox();
            this.txtModbusServer3 = new System.Windows.Forms.TextBox();
            this.txtModbusServer6 = new System.Windows.Forms.TextBox();
            this.txtModbusServer5 = new System.Windows.Forms.TextBox();
            this.txtModbusServer7 = new System.Windows.Forms.TextBox();
            this.txtModbusServer4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtModbusServer8 = new System.Windows.Forms.TextBox();
            this.txtModbusServer9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ModbusServerIP :";
            // 
            // btnBaglantıAc
            // 
            this.btnBaglantıAc.Location = new System.Drawing.Point(123, 60);
            this.btnBaglantıAc.Name = "btnBaglantıAc";
            this.btnBaglantıAc.Size = new System.Drawing.Size(187, 36);
            this.btnBaglantıAc.TabIndex = 1;
            this.btnBaglantıAc.Text = "Connect";
            this.btnBaglantıAc.UseVisualStyleBackColor = true;
            this.btnBaglantıAc.Click += new System.EventHandler(this.btnBaglantıAc_Click);
            // 
            // btnBaglantıKapat
            // 
            this.btnBaglantıKapat.Location = new System.Drawing.Point(123, 117);
            this.btnBaglantıKapat.Name = "btnBaglantıKapat";
            this.btnBaglantıKapat.Size = new System.Drawing.Size(187, 36);
            this.btnBaglantıKapat.TabIndex = 2;
            this.btnBaglantıKapat.Text = "Disconnect";
            this.btnBaglantıKapat.UseVisualStyleBackColor = true;
            this.btnBaglantıKapat.Click += new System.EventHandler(this.btnBaglantıKapat_Click);
            // 
            // txtServerIPAdress
            // 
            this.txtServerIPAdress.Location = new System.Drawing.Point(123, 21);
            this.txtServerIPAdress.Name = "txtServerIPAdress";
            this.txtServerIPAdress.Size = new System.Drawing.Size(187, 22);
            this.txtServerIPAdress.TabIndex = 3;
            this.txtServerIPAdress.Text = "192.168.1.34";
            // 
            // lblBaglantıDurumu
            // 
            this.lblBaglantıDurumu.AutoSize = true;
            this.lblBaglantıDurumu.Location = new System.Drawing.Point(646, 26);
            this.lblBaglantıDurumu.Name = "lblBaglantıDurumu";
            this.lblBaglantıDurumu.Size = new System.Drawing.Size(102, 17);
            this.lblBaglantıDurumu.TabIndex = 5;
            this.lblBaglantıDurumu.Text = "Baglantı Kapalı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status : ";
            // 
            // tmrModbusTcpIP
            // 
            this.tmrModbusTcpIP.Tick += new System.EventHandler(this.tmrModbusTcpIP_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "ModbusRegister0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ModbusRegister1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ModbusRegister2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "ModbusRegister3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "ModbusRegister4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "ModbusRegister5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "ModbusRegister6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "ModbusRegister7";
            // 
            // txtModbusServer0
            // 
            this.txtModbusServer0.Location = new System.Drawing.Point(135, 174);
            this.txtModbusServer0.Name = "txtModbusServer0";
            this.txtModbusServer0.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer0.TabIndex = 15;
            // 
            // txtModbusServer1
            // 
            this.txtModbusServer1.Location = new System.Drawing.Point(135, 202);
            this.txtModbusServer1.Name = "txtModbusServer1";
            this.txtModbusServer1.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer1.TabIndex = 16;
            // 
            // txtModbusServer2
            // 
            this.txtModbusServer2.Location = new System.Drawing.Point(135, 230);
            this.txtModbusServer2.Name = "txtModbusServer2";
            this.txtModbusServer2.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer2.TabIndex = 17;
            // 
            // txtModbusServer3
            // 
            this.txtModbusServer3.Location = new System.Drawing.Point(135, 258);
            this.txtModbusServer3.Name = "txtModbusServer3";
            this.txtModbusServer3.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer3.TabIndex = 18;
            // 
            // txtModbusServer6
            // 
            this.txtModbusServer6.Location = new System.Drawing.Point(135, 344);
            this.txtModbusServer6.Name = "txtModbusServer6";
            this.txtModbusServer6.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer6.TabIndex = 19;
            // 
            // txtModbusServer5
            // 
            this.txtModbusServer5.Location = new System.Drawing.Point(135, 314);
            this.txtModbusServer5.Name = "txtModbusServer5";
            this.txtModbusServer5.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer5.TabIndex = 20;
            // 
            // txtModbusServer7
            // 
            this.txtModbusServer7.Location = new System.Drawing.Point(135, 372);
            this.txtModbusServer7.Name = "txtModbusServer7";
            this.txtModbusServer7.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer7.TabIndex = 21;
            // 
            // txtModbusServer4
            // 
            this.txtModbusServer4.Location = new System.Drawing.Point(135, 286);
            this.txtModbusServer4.Name = "txtModbusServer4";
            this.txtModbusServer4.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer4.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 405);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "ModbusRegister8";
            // 
            // txtModbusServer8
            // 
            this.txtModbusServer8.Location = new System.Drawing.Point(135, 400);
            this.txtModbusServer8.Name = "txtModbusServer8";
            this.txtModbusServer8.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer8.TabIndex = 41;
            // 
            // txtModbusServer9
            // 
            this.txtModbusServer9.Location = new System.Drawing.Point(135, 428);
            this.txtModbusServer9.Name = "txtModbusServer9";
            this.txtModbusServer9.Size = new System.Drawing.Size(187, 22);
            this.txtModbusServer9.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 433);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 17);
            this.label21.TabIndex = 45;
            this.label21.Text = "ModbusRegister9";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(546, 205);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 48;
            this.label23.Text = "Address";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(545, 238);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 49;
            this.label24.Text = "Quantity";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(649, 200);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(162, 22);
            this.txtAdress.TabIndex = 50;
            this.txtAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdress_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(648, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 51;
            this.textBox2.Text = "10";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(545, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 52;
            this.label25.Text = "Slave ID : ";
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.Location = new System.Drawing.Point(649, 74);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(162, 22);
            this.txtSlaveId.TabIndex = 53;
            this.txtSlaveId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlaveId_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(543, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 17);
            this.label26.TabIndex = 54;
            this.label26.Text = "Function : ";
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "03 Read Holding Register(4x)",
            "Read Coils(0x)",
            "04 Input Register(3x)",
            "02 Input Status(1x)"});
            this.cboState.Location = new System.Drawing.Point(649, 117);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(161, 24);
            this.cboState.TabIndex = 55;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(545, 164);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 17);
            this.label27.TabIndex = 56;
            this.label27.Text = "Selected : ";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(646, 164);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(16, 17);
            this.lblValue.TabIndex = 57;
            this.lblValue.Text = "?";
            // 
            // txtMesaj
            // 
            this.txtMesaj.AutoSize = true;
            this.txtMesaj.Location = new System.Drawing.Point(645, 286);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(120, 17);
            this.txtMesaj.TabIndex = 58;
            this.txtMesaj.Text = "Error Messages  :";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(327, 21);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(46, 17);
            this.label111.TabIndex = 59;
            this.label111.Text = "Port : ";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(393, 18);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 22);
            this.txtPort.TabIndex = 60;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 450);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtSlaveId);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtModbusServer9);
            this.Controls.Add(this.txtModbusServer8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtModbusServer4);
            this.Controls.Add(this.txtModbusServer7);
            this.Controls.Add(this.txtModbusServer5);
            this.Controls.Add(this.txtModbusServer6);
            this.Controls.Add(this.txtModbusServer3);
            this.Controls.Add(this.txtModbusServer2);
            this.Controls.Add(this.txtModbusServer1);
            this.Controls.Add(this.txtModbusServer0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaglantıDurumu);
            this.Controls.Add(this.txtServerIPAdress);
            this.Controls.Add(this.btnBaglantıKapat);
            this.Controls.Add(this.btnBaglantıAc);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaglantıAc;
        private System.Windows.Forms.Button btnBaglantıKapat;
        private System.Windows.Forms.TextBox txtServerIPAdress;
        private System.Windows.Forms.Label lblBaglantıDurumu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrModbusTcpIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModbusServer0;
        private System.Windows.Forms.TextBox txtModbusServer1;
        private System.Windows.Forms.TextBox txtModbusServer2;
        private System.Windows.Forms.TextBox txtModbusServer3;
        private System.Windows.Forms.TextBox txtModbusServer6;
        private System.Windows.Forms.TextBox txtModbusServer5;
        private System.Windows.Forms.TextBox txtModbusServer7;
        private System.Windows.Forms.TextBox txtModbusServer4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtModbusServer8;
        private System.Windows.Forms.TextBox txtModbusServer9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label txtMesaj;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.TextBox txtPort;
    }
}

