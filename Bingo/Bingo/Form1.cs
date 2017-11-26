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
                    for (int i = 0; i < 25; ++i)
                    {
                        
                            do
                            {
                                number = rnd.Next(0, bingoList.Count);
                            } while (bingoarray.Contains(number));
                            bingoarray.Add(number);
                        

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
                for (int i = 0; i < 25; ++i)
                {
                    
                        do
                        {
                            number = rnd.Next(0, bingoList.Count);
                        } while (bingoarray.Contains(number));
                        bingoarray.Add(number);
                   

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
                focusWindow(checkBox1.Text, checkBox10.Text, checkBox15.Text, checkBox20.Text, checkBox25.Text);
                
            }

        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                focusWindow(checkBox2.Text, checkBox9.Text, checkBox14.Text, checkBox19.Text, checkBox24.Text);
            }

           
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                focusWindow(checkBox3.Text, checkBox8.Text, checkBox13.Text, checkBox18.Text, checkBox23.Text);
                
            }

           
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                focusWindow(checkBox4.Text, checkBox7.Text, checkBox12.Text, checkBox17.Text, checkBox22.Text);
                
            }

           
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                focusWindow(checkBox5.Text, checkBox6.Text, checkBox11.Text, checkBox16.Text, checkBox21.Text);
            }

           
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
             
                focusWindow(checkBox1.Text, checkBox2.Text, checkBox3.Text, checkBox4.Text, checkBox5.Text);
 
            }

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                focusWindow(checkBox10.Text, checkBox9.Text, checkBox8.Text, checkBox7.Text, checkBox6.Text);
  
            }

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                focusWindow(checkBox11.Text, checkBox12.Text, checkBox13.Text, checkBox14.Text, checkBox15.Text);
  
            }

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                focusWindow(checkBox16.Text, checkBox17.Text, checkBox18.Text, checkBox19.Text, checkBox20.Text);
  
            }

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                focusWindow(checkBox25.Text, checkBox24.Text, checkBox23.Text, checkBox22.Text, checkBox21.Text);
  
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
        public void focusWindow(String box1, String box2, String box3,String box4,String box5)
        {
            
            BoxesFocus boxes = new BoxesFocus();
            boxes.Box1 = box1;
            boxes.Box2 = box2;
            boxes.Box3 = box3;
            boxes.Box4 = box4;
            boxes.Box5 = box5;
            Form2 focus = new Form2(boxes);
          focus.FormClosed += focus_FormClosed;
           // focus.Shown += ToggleControls;
           
            focus.ShowDialog();
        }

        private void focus_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            checkBox37.Checked = false;
           
           
        }
        private void ToggleControls(object sender, EventArgs e)
        {
           
            foreach (Control c in this.Controls)
            {
                c.Enabled = !c.Enabled;
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                focusWindow(checkBox1.Text, checkBox9.Text, checkBox13.Text, checkBox17.Text, checkBox21.Text);

            }

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                focusWindow(checkBox25.Text, checkBox19.Text, checkBox13.Text, checkBox7.Text, checkBox5.Text);
  
            }
            
        }
       


    }
}
