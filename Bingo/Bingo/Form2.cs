using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form2 : Form
    {
       private BoxesFocus boxes;

        public Form2(BoxesFocus boxes)
        {
            InitializeComponent();
            this.boxes = boxes;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Text = boxes.Box1;
            checkBox2.Text = boxes.Box2;
            checkBox3.Text = boxes.Box3;
            checkBox4.Text = boxes.Box4;
            checkBox5.Text = boxes.Box5;
        }
    }
}
