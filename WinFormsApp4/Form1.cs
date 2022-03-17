using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* CHANDLER DUKE. COMP LANG 1.
 * THIS PROGRAM USES WINDOWS FORM TO REQUEST SHAPE DIMENSIONS FROM USER AND CALCULATE AREA
 */

namespace WinFormsApp4
{
    //BUSINESS LAYER AND EVENT HANDLING
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Hide();
            groupBox3.Hide();
        }
        
        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Event handling to show/hide rectangle shape component
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked == true)
            {
                groupBox2.Show();
            }
            else
            {
                groupBox2.Hide();
            }

        }

        // method not being used, VS studio wont let me get rid of it?
        private void groupBox2_VisibleChanged(object sender, EventArgs e)
        {

        }

        // method not being used, VS studio wont let me get rid of it?
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // Event handling to show/hide circle shape component
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
            {
                groupBox3.Show();
            }
            else
            {
                groupBox3.Hide();
            }
        }

        // Event handling to show/hide cylinder shape component
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true || this.radioButton3.Checked == true)
            {
                groupBox4.Hide();
            }
            else
            {
                groupBox4.Show();
            }
        }

        // method not being used, VS studio wont let me get rid of it?
        private void label8_Click(object sender, EventArgs e)
        {

        }

        // method not being used, VS studio wont let me get rid of it?
        private void groupBox3_VisibleChanged(object sender, EventArgs e)
        {

        }

        // method not being used, VS studio wont let me get rid of it?
        private void groupBox4_VisibleChanged(object sender, EventArgs e)
        {

        }

        // method not being used, VS studio wont let me get rid of it?
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Event handling for computing circle shape area when "compute" button is clicked//
        private void button2_Click(object sender, EventArgs e)
        {
            string invalue;
            int cirRadius;
           
            if (Int32.TryParse(textBox4.Text, out cirRadius) == false)
            {
                MessageBox.Show("Value must be integer value");
                textBox4.Text = "0";
                textBox4.Focus();
            }
            
            invalue = textBox4.Text;
            cirRadius = Int32.Parse(textBox4.Text);
            double cirArea = (Math.Pow(cirRadius, 2) * Math.PI);
            textBox5.Text = string.Format("{0}", cirArea);
            Circle circle1 = new Circle(cirRadius, cirArea);

        }

        // Event handling for computing cylinder shape area when "compute" button is clicked//
        private void button3_Click(object sender, EventArgs e)
        {
            string invalue1;
            string invalue2;
            int cylHeight;
            int cylRadius;
            

            if (Int32.TryParse(textBox6.Text, out cylHeight) == false)
            {
                MessageBox.Show("Value must be integer value");
                textBox6.Text = "0";
                textBox6.Focus();
            }
            if (Int32.TryParse(textBox7.Text, out cylRadius) == false)
            {
                MessageBox.Show("Value must be integer value");
                textBox7.Text = "0";
                textBox7.Focus();
            }

            invalue1 = textBox6.Text;
            invalue2 = textBox7.Text;
            cylHeight = Int32.Parse(textBox6.Text);
            cylRadius = Int32.Parse(textBox7.Text);
            double cylArea = ((Math.Pow(cylRadius, 2) * Math.PI) * cylHeight);
            textBox8.Text = string.Format("{0}", cylArea);
            Cylinder cylinder = new Cylinder(cylHeight, cylRadius, cylArea);            
        }

        // Event handling for computing rectangle shape area when "compute" button is clicked//
        private void button1_Click(object sender, EventArgs e)
        {
            string invalue1;
            string invalue2;
            int recHeight;
            int recWidth;
            
            if (Int32.TryParse(textBox1.Text, out recHeight) == false)
            {
                MessageBox.Show("Value must be integer value");
                textBox1.Text = "0";
                textBox1.Focus();
            }
            if (Int32.TryParse(textBox2.Text, out recWidth) == false)
            {
                MessageBox.Show("Value must be integer value");
                textBox2.Text = "0";
                textBox2.Focus();
            }

            invalue1 = textBox2.Text;
            invalue2 = textBox1.Text;
            recHeight = Int32.Parse(textBox1.Text);
            recWidth = Int32.Parse(textBox2.Text);
            double recArea = (recHeight * recWidth);
            textBox3.Text = string.Format("{0}", recArea); 
            Rectangle rectangle = new Rectangle(recHeight, recWidth, recArea);
        }

        // event handling when the "reset" button is clicked. Clear all input text boxes
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

        }
    }
}
