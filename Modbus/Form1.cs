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
                txtSlaveId.ReadOnly = true;
                txtAdress.ReadOnly = true;
                
                modbusClient = new ModbusClient(txtServerIPAdress.Text, Convert.ToInt16(txtPort.Text));
                
          
                modbusClient.Connect();

                lblBaglantıDurumu.Text = "Baglantı Başarılı";
                tmrModbusTcpIP.Enabled = true;
             

            }
            catch (Exception ex )
            {

                lblBaglantıDurumu.Text = ex.Message;
            }

        }

        private void tmrModbusTcpIP_Tick(object sender, EventArgs e)
        {
            tmrModbusTcpIP.Enabled = false;

            //modbusClient.WriteMultipleRegisters(startingAddress: 0, new int[] { 11, 22, 33, 44, 55, 89,  44, 21 ,33});


           
           


            try
            {
                if (lblValue.Text == "03 Read Holding Register(4x)")
                {
                    try
                    {
                        modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    }
                    catch (Exception ex)
                    {
                        txtMesaj.Text = ex.Message;
                    }




                    if ((byte)Convert.ToInt16(txtSlaveId.Text) > 0 || (byte)Convert.ToInt16(txtSlaveId.Text) < 255)
                        {



                        }
                    
                    else
                    {
                        MessageBox.Show("Girdiğiniz SlaveId değeri 1 - 247 arasında olmalı");

                        
                    }

                  

                    int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(startingAddress: Convert.ToInt16(txtAdress.Text), quantity: 10);

                    txtModbusServer0.Text = readHoldingRegisters[0].ToString();
                    txtModbusServer1.Text = readHoldingRegisters[1].ToString();
                    txtModbusServer2.Text = readHoldingRegisters[2].ToString();
                    txtModbusServer3.Text = readHoldingRegisters[3].ToString();
                    txtModbusServer4.Text = readHoldingRegisters[4].ToString();
                    txtModbusServer5.Text = readHoldingRegisters[5].ToString();
                    txtModbusServer6.Text = readHoldingRegisters[6].ToString();
                    txtModbusServer7.Text = readHoldingRegisters[7].ToString();
                    txtModbusServer8.Text = readHoldingRegisters[8].ToString();
                    txtModbusServer9.Text = readHoldingRegisters[9].ToString();
                }

                else if (lblValue.Text == "Read Coils(0x)")
                {
                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    bool[] readCoils = modbusClient.ReadCoils(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: 10);

                    txtModbusServer0.Text = readCoils[0].ToString();
                    txtModbusServer1.Text = readCoils[1].ToString();
                    txtModbusServer2.Text = readCoils[2].ToString();
                    txtModbusServer3.Text = readCoils[3].ToString();
                    txtModbusServer4.Text = readCoils[4].ToString();
                    txtModbusServer5.Text = readCoils[5].ToString();
                    txtModbusServer6.Text = readCoils[6].ToString();
                    txtModbusServer7.Text = readCoils[7].ToString();
                    txtModbusServer8.Text = readCoils[8].ToString();
                    txtModbusServer9.Text = readCoils[9].ToString();
                }


                else if (lblValue.Text == "04 Input Register(3x)")
                {
                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    int[] inputRegister = modbusClient.ReadInputRegisters(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: 10);

                    txtModbusServer0.Text = inputRegister[0].ToString();
                    txtModbusServer1.Text = inputRegister[1].ToString();
                    txtModbusServer2.Text = inputRegister[2].ToString();
                    txtModbusServer3.Text = inputRegister[3].ToString();
                    txtModbusServer4.Text = inputRegister[4].ToString();
                    txtModbusServer5.Text = inputRegister[5].ToString();
                    txtModbusServer6.Text = inputRegister[6].ToString();
                    txtModbusServer7.Text = inputRegister[7].ToString();
                    txtModbusServer8.Text = inputRegister[8].ToString();
                    txtModbusServer9.Text = inputRegister[9].ToString();
                }


                else if (lblValue.Text == "02 Input Status(1x)")
                {

                    modbusClient.UnitIdentifier = (byte)Convert.ToInt16(txtSlaveId.Text);
                    bool[] inputStatus = modbusClient.ReadDiscreteInputs(startingAddress: Convert.ToInt32(txtAdress.Text), quantity: 10);

                    for (int i = Convert.ToInt32(txtAdress.Text); i < 10; i++)
                    {
                        txtModbusServer0.Text = inputStatus[0].ToString();
                        txtModbusServer1.Text = inputStatus[1].ToString();
                        txtModbusServer2.Text = inputStatus[2].ToString();
                        txtModbusServer3.Text = inputStatus[3].ToString();
                        txtModbusServer4.Text = inputStatus[4].ToString();
                        txtModbusServer5.Text = inputStatus[5].ToString();
                        txtModbusServer6.Text = inputStatus[6].ToString();
                        txtModbusServer7.Text = inputStatus[7].ToString();
                        txtModbusServer8.Text = inputStatus[8].ToString();
                        txtModbusServer9.Text = inputStatus[9].ToString();

                    }

                }
            }
            catch(Exception ex)
            {
                txtMesaj.Text = ex.Message;
           
            }
        



            ////modbusClient.WriteMultipleCoils(startingAddress: 0, values: new[] { true, true, false, true, true, false, true, false, true, false });



            tmrModbusTcpIP.Enabled = true;


        }

        private void btnBaglantıKapat_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                modbusClient.Disconnect();
                lblBaglantıDurumu.Text = "Baglantı Kapalı";
                tmrModbusTcpIP.Enabled = false;
                txtSlaveId.ReadOnly = false;
                txtAdress.ReadOnly = false;

            }
            catch (Exception ex)
            {
              lblBaglantıDurumu.Text = ex.Message;
            }



        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = cboState.Text;

        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Buraya Sadece Sayı giriniz");
            }

        }

        private void txtSlaveId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Buraya Sadece Sayı giriniz");
            }

        }
    }
}
