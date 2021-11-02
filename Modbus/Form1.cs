using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using EasyModbus.Exceptions;

namespace Modbus
{
    public partial class form : Form
    {
        ModbusClient modbusClient;
        public form()
        {
            InitializeComponent();
        }

        private void btnBaglantıAc_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(txtServerIPAdress.Text, port: 502);
                modbusClient.Connect();
                lblBaglantıDurumu.Text = "Baglantı Başarılı";
                tmrModbusTcpIP.Enabled = true;

            }
            catch (Exception ex)
            {

                lblBaglantıDurumu.Text = ex.ToString();
            }

        }

        private void tmrModbusTcpIP_Tick(object sender, EventArgs e)
        {
            tmrModbusTcpIP.Enabled = false;

            //modbusClient.WriteMultipleRegisters(startingAddress: 0, new int[] { 11, 22, 33, 44, 55, 89,  44, 21 ,33});


            if (lblValue.Text == "03 Read Holding Register(4x)")
            {
                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(startingAddress:Convert.ToInt32(txtAdress), quantity: 10) ;
                 //txtHoldingRegister;
                for(int i= Convert.ToInt32(txtAdress.Text); i < 10; i++)
                {
                    //txtHoldingRegister = $"txtHoldingRegister{i}.Text = readHoldingRegisters[{i}].ToString()";
                    txtHoldingRegister0.Text = readHoldingRegisters[0].ToString();
                    txtHoldingRegister1.Text = readHoldingRegisters[1].ToString();
                    txtHoldingRegister2.Text = readHoldingRegisters[2].ToString();
                    txtHoldingRegister3.Text = readHoldingRegisters[3].ToString();
                    txtHoldingRegister4.Text = readHoldingRegisters[4].ToString();
                    txtHoldingRegister5.Text = readHoldingRegisters[5].ToString();
                    txtHoldingRegister6.Text = readHoldingRegisters[6].ToString();
                    txtHoldingRegister7.Text = readHoldingRegisters[7].ToString();
                    txtHoldingRegister8.Text = readHoldingRegisters[8].ToString();
                    txtHoldingRegister9.Text = readHoldingRegisters[9].ToString();
                }
                
                
            }

            else if(lblValue.Text== "Read Coils(0x)")
            {
                
                bool[] readCoils = modbusClient.ReadCoils(startingAddress:Convert.ToInt32(txtAdress.Text), quantity: 10);

                txtHoldingRegister0.Text = readCoils[0].ToString();
                txtHoldingRegister1.Text = readCoils[1].ToString();
                txtHoldingRegister2.Text = readCoils[2].ToString();
                txtHoldingRegister3.Text = readCoils[3].ToString();
                txtHoldingRegister4.Text = readCoils[4].ToString();
                txtHoldingRegister5.Text = readCoils[5].ToString();
                txtHoldingRegister6.Text = readCoils[6].ToString();
                txtHoldingRegister7.Text = readCoils[7].ToString();
                txtHoldingRegister8.Text = readCoils[8].ToString();
                txtHoldingRegister9.Text = readCoils[9].ToString();
            }








            ////modbusClient.WriteMultipleCoils(startingAddress: 0, values: new[] { true, true, false, true, true, false, true, false, true, false });



            tmrModbusTcpIP.Enabled = true;


        }

        private void btnBaglantıKapat_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            lblBaglantıDurumu.Text = "Baglantı Kapalı";
            tmrModbusTcpIP.Enabled = false;

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = cboState.Text;
        }
    }
}
