using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Bingo.xml");
                XmlNodeList bingoList = doc.GetElementsByTagName("Items");
                int seedNumber = 0;
                if (int.TryParse(textBox1.Text, out seedNumber))
                {
                    Random rnd = new Random(seedNumber);

                    List<int> bingoarray = new List<int>();
                    int number;
                    for (int i = 0; i < 5; ++i)
                    {
                        for (int j = 0; j < 5; ++j)
                        {
                            do
                            {
                                number = rnd.Next(0, bingoList.Count);
                            } while (bingoarray.Contains(number));
                            bingoarray.Add(number);
                        }

                    }
                    textBox1.Text = seedNumber + "";
                    checkBox1.Text = bingoList[bingoarray[0]].InnerText;
                    checkBox2.Text = bingoList[bingoarray[1]].InnerText;
                    checkBox3.Text = bingoList[bingoarray[2]].InnerText;
                    checkBox4.Text = bingoList[bingoarray[3]].InnerText;
                    checkBox5.Text = bingoList[bingoarray[4]].InnerText;
                    checkBox6.Text = bingoList[bingoarray[5]].InnerText;
                    checkBox7.Text = bingoList[bingoarray[6]].InnerText;
                    checkBox8.Text = bingoList[bingoarray[7]].InnerText;
                    checkBox9.Text = bingoList[bingoarray[8]].InnerText;
                    checkBox10.Text = bingoList[bingoarray[9]].InnerText;
                    checkBox11.Text = bingoList[bingoarray[10]].InnerText;
                    checkBox12.Text = bingoList[bingoarray[11]].InnerText;
                    checkBox13.Text = bingoList[bingoarray[12]].InnerText;
                    checkBox14.Text = bingoList[bingoarray[13]].InnerText;
                    checkBox15.Text = bingoList[bingoarray[14]].InnerText;
                    checkBox16.Text = bingoList[bingoarray[15]].InnerText;
                    checkBox17.Text = bingoList[bingoarray[16]].InnerText;
                    checkBox18.Text = bingoList[bingoarray[17]].InnerText;
                    checkBox19.Text = bingoList[bingoarray[18]].InnerText;
                    checkBox20.Text = bingoList[bingoarray[19]].InnerText;
                    checkBox21.Text = bingoList[bingoarray[20]].InnerText;
                    checkBox22.Text = bingoList[bingoarray[21]].InnerText;
                    checkBox23.Text = bingoList[bingoarray[22]].InnerText;
                    checkBox24.Text = bingoList[bingoarray[23]].InnerText;
                    checkBox25.Text = bingoList[bingoarray[24]].InnerText;
                }
                else
                {
                    MessageBox.Show("Enter a number and no letters or symbols.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Bingo.xml not found.");
            }


        }
        public void loadCard()
        {

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Bingo.xml");
                XmlNodeList bingoList = doc.GetElementsByTagName("Items");
                Random rndseed = new Random();
                int seedNumber = rndseed.Next(0, 50000);
                Random rnd = new Random(seedNumber);
                // int[,] bingoarray = new int[5, 5];
                List<int> bingoarray = new List<int>();
                int number;
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        do
                        {
                            number = rnd.Next(0, bingoList.Count);
                        } while (bingoarray.Contains(number));
                        bingoarray.Add(number);
                    }

                }
                textBox1.Text = seedNumber + "";
                checkBox1.Text = bingoList[bingoarray[0]].InnerText;
                checkBox2.Text = bingoList[bingoarray[1]].InnerText;
                checkBox3.Text = bingoList[bingoarray[2]].InnerText;
                checkBox4.Text = bingoList[bingoarray[3]].InnerText;
                checkBox5.Text = bingoList[bingoarray[4]].InnerText;
                checkBox6.Text = bingoList[bingoarray[5]].InnerText;
                checkBox7.Text = bingoList[bingoarray[6]].InnerText;
                checkBox8.Text = bingoList[bingoarray[7]].InnerText;
                checkBox9.Text = bingoList[bingoarray[8]].InnerText;
                checkBox10.Text = bingoList[bingoarray[9]].InnerText;
                checkBox11.Text = bingoList[bingoarray[10]].InnerText;
                checkBox12.Text = bingoList[bingoarray[11]].InnerText;
                checkBox13.Text = bingoList[bingoarray[12]].InnerText;
                checkBox14.Text = bingoList[bingoarray[13]].InnerText;
                checkBox15.Text = bingoList[bingoarray[14]].InnerText;
                checkBox16.Text = bingoList[bingoarray[15]].InnerText;
                checkBox17.Text = bingoList[bingoarray[16]].InnerText;
                checkBox18.Text = bingoList[bingoarray[17]].InnerText;
                checkBox19.Text = bingoList[bingoarray[18]].InnerText;
                checkBox20.Text = bingoList[bingoarray[19]].InnerText;
                checkBox21.Text = bingoList[bingoarray[20]].InnerText;
                checkBox22.Text = bingoList[bingoarray[21]].InnerText;
                checkBox23.Text = bingoList[bingoarray[22]].InnerText;
                checkBox24.Text = bingoList[bingoarray[23]].InnerText;
                checkBox25.Text = bingoList[bingoarray[24]].InnerText;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Bingo.xml not found.");
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
              if (checkBox31.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox26.Enabled = false;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;

            }
          
             else
             {
                
                     checkBox2.Enabled = true;
                     checkBox2.BackColor = Color.CadetBlue;
                     checkBox3.Enabled = true;
                     checkBox3.BackColor = Color.CadetBlue;
                     checkBox4.Enabled = true;
                     checkBox4.BackColor = Color.CadetBlue;
                     checkBox5.Enabled = true;
                     checkBox5.BackColor = Color.CadetBlue;
                     checkBox6.Enabled = true;
                     checkBox6.BackColor = Color.CadetBlue;
                     checkBox7.Enabled = true;
                     checkBox7.BackColor = Color.CadetBlue;
                     checkBox8.Enabled = true;
                     checkBox8.BackColor = Color.CadetBlue;
                     checkBox9.Enabled = true;
                     checkBox9.BackColor = Color.CadetBlue;
                     checkBox11.Enabled = true;
                     checkBox11.BackColor = Color.CadetBlue;
                     checkBox12.Enabled = true;
                     checkBox12.BackColor = Color.CadetBlue;
                     checkBox13.Enabled = true;
                     checkBox13.BackColor = Color.CadetBlue;
                     checkBox14.Enabled = true;
                     checkBox14.BackColor = Color.CadetBlue;
                     checkBox16.Enabled = true;
                     checkBox16.BackColor = Color.CadetBlue;
                     checkBox17.Enabled = true;
                     checkBox17.BackColor = Color.CadetBlue;
                     checkBox18.Enabled = true;
                     checkBox18.BackColor = Color.CadetBlue;
                     checkBox19.Enabled = true;
                     checkBox19.BackColor = Color.CadetBlue;
                     checkBox21.Enabled = true;
                     checkBox21.BackColor = Color.CadetBlue;
                     checkBox22.Enabled = true;
                     checkBox22.BackColor = Color.CadetBlue;
                     checkBox23.Enabled = true;
                     checkBox23.BackColor = Color.CadetBlue;
                     checkBox24.Enabled = true;
                     checkBox24.BackColor = Color.CadetBlue;
                     checkBox26.Enabled = true;
                     checkBox26.BackColor = Color.CadetBlue;
                     checkBox27.Enabled = true;
                     checkBox27.BackColor = Color.CadetBlue;
                     checkBox28.Enabled = true;
                     checkBox28.BackColor = Color.CadetBlue;
                     checkBox29.Enabled = true;
                     checkBox29.BackColor = Color.CadetBlue;
                     checkBox30.Enabled = true;
                     checkBox30.BackColor = Color.CadetBlue;
                     checkBox32.Enabled = true;
                     checkBox32.BackColor = Color.CadetBlue;
                     checkBox33.Enabled = true;
                     checkBox33.BackColor = Color.CadetBlue;
                     checkBox34.Enabled = true;
                     checkBox34.BackColor = Color.CadetBlue;
                     checkBox35.Enabled = true;
                     checkBox35.BackColor = Color.CadetBlue;
                 
             }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
            }

            else
            {

                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;

            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
            }

            else
            {

                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;
            

            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
            }

            else
            {

                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;


            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
            }

            else
            {

                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;


            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
            }

            else
            {

                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;


            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
                checkBox26.Enabled = false;
                checkBox26.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
            }

            else
            {

                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;


            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
                checkBox26.Enabled = false;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
            }

            else
            {

                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;


            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox21.Enabled = false;
                checkBox21.BackColor = Color.Gray;
                checkBox22.Enabled = false;
                checkBox22.BackColor = Color.Gray;
                checkBox23.Enabled = false;
                checkBox23.BackColor = Color.Gray;
                checkBox24.Enabled = false;
                checkBox24.BackColor = Color.Gray;
                checkBox25.Enabled = false;
                checkBox25.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
                checkBox26.Enabled = false;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox30.Enabled = false;
                checkBox30.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
            }

            else
            {

                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox21.Enabled = true;
                checkBox21.BackColor = Color.CadetBlue;
                checkBox22.Enabled = true;
                checkBox22.BackColor = Color.CadetBlue;
                checkBox23.Enabled = true;
                checkBox23.BackColor = Color.CadetBlue;
                checkBox24.Enabled = true;
                checkBox24.BackColor = Color.CadetBlue;
                checkBox25.Enabled = true;
                checkBox25.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox30.Enabled = true;
                checkBox30.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;


            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox1.BackColor = Color.Gray;
                checkBox2.Enabled = false;
                checkBox2.BackColor = Color.Gray;
                checkBox3.Enabled = false;
                checkBox3.BackColor = Color.Gray;
                checkBox4.Enabled = false;
                checkBox4.BackColor = Color.Gray;
                checkBox5.Enabled = false;
                checkBox5.BackColor = Color.Gray;
                checkBox6.Enabled = false;
                checkBox6.BackColor = Color.Gray;
                checkBox7.Enabled = false;
                checkBox7.BackColor = Color.Gray;
                checkBox8.Enabled = false;
                checkBox8.BackColor = Color.Gray;
                checkBox9.Enabled = false;
                checkBox9.BackColor = Color.Gray;
                checkBox10.Enabled = false;
                checkBox10.BackColor = Color.Gray;
                checkBox11.Enabled = false;
                checkBox11.BackColor = Color.Gray;
                checkBox12.Enabled = false;
                checkBox12.BackColor = Color.Gray;
                checkBox13.Enabled = false;
                checkBox13.BackColor = Color.Gray;
                checkBox14.Enabled = false;
                checkBox14.BackColor = Color.Gray;
                checkBox15.Enabled = false;
                checkBox15.BackColor = Color.Gray;
                checkBox16.Enabled = false;
                checkBox16.BackColor = Color.Gray;
                checkBox17.Enabled = false;
                checkBox17.BackColor = Color.Gray;
                checkBox18.Enabled = false;
                checkBox18.BackColor = Color.Gray;
                checkBox19.Enabled = false;
                checkBox19.BackColor = Color.Gray;
                checkBox20.Enabled = false;
                checkBox20.BackColor = Color.Gray;
                checkBox35.Enabled = false;
                checkBox35.BackColor = Color.Gray;
                checkBox26.Enabled = false;
                checkBox26.BackColor = Color.Gray;
                checkBox27.Enabled = false;
                checkBox27.BackColor = Color.Gray;
                checkBox28.Enabled = false;
                checkBox28.BackColor = Color.Gray;
                checkBox29.Enabled = false;
                checkBox29.BackColor = Color.Gray;
                checkBox31.Enabled = false;
                checkBox31.BackColor = Color.Gray;
                checkBox32.Enabled = false;
                checkBox32.BackColor = Color.Gray;
                checkBox33.Enabled = false;
                checkBox33.BackColor = Color.Gray;
                checkBox34.Enabled = false;
                checkBox34.BackColor = Color.Gray;
            }

            else
            {

                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.CadetBlue;
                checkBox2.Enabled = true;
                checkBox2.BackColor = Color.CadetBlue;
                checkBox3.Enabled = true;
                checkBox3.BackColor = Color.CadetBlue;
                checkBox4.Enabled = true;
                checkBox4.BackColor = Color.CadetBlue;
                checkBox5.Enabled = true;
                checkBox5.BackColor = Color.CadetBlue;
                checkBox6.Enabled = true;
                checkBox6.BackColor = Color.CadetBlue;
                checkBox7.Enabled = true;
                checkBox7.BackColor = Color.CadetBlue;
                checkBox8.Enabled = true;
                checkBox8.BackColor = Color.CadetBlue;
                checkBox9.Enabled = true;
                checkBox9.BackColor = Color.CadetBlue;
                checkBox10.Enabled = true;
                checkBox10.BackColor = Color.CadetBlue;
                checkBox11.Enabled = true;
                checkBox11.BackColor = Color.CadetBlue;
                checkBox12.Enabled = true;
                checkBox12.BackColor = Color.CadetBlue;
                checkBox13.Enabled = true;
                checkBox13.BackColor = Color.CadetBlue;
                checkBox14.Enabled = true;
                checkBox14.BackColor = Color.CadetBlue;
                checkBox15.Enabled = true;
                checkBox15.BackColor = Color.CadetBlue;
                checkBox16.Enabled = true;
                checkBox16.BackColor = Color.CadetBlue;
                checkBox17.Enabled = true;
                checkBox17.BackColor = Color.CadetBlue;
                checkBox18.Enabled = true;
                checkBox18.BackColor = Color.CadetBlue;
                checkBox19.Enabled = true;
                checkBox19.BackColor = Color.CadetBlue;
                checkBox20.Enabled = true;
                checkBox20.BackColor = Color.CadetBlue;
                checkBox35.Enabled = true;
                checkBox35.BackColor = Color.CadetBlue;
                checkBox26.Enabled = true;
                checkBox26.BackColor = Color.CadetBlue;
                checkBox27.Enabled = true;
                checkBox27.BackColor = Color.CadetBlue;
                checkBox28.Enabled = true;
                checkBox28.BackColor = Color.CadetBlue;
                checkBox29.Enabled = true;
                checkBox29.BackColor = Color.CadetBlue;
                checkBox31.Enabled = true;
                checkBox31.BackColor = Color.CadetBlue;
                checkBox32.Enabled = true;
                checkBox32.BackColor = Color.CadetBlue;
                checkBox33.Enabled = true;
                checkBox33.BackColor = Color.CadetBlue;
                checkBox34.Enabled = true;
                checkBox34.BackColor = Color.CadetBlue;


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(sender, e);
            }        
        }



    }
}
