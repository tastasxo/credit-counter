using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credit_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null then
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label1.Text); // covert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 1p is clicked it increases by 1
                label1.Text = hold_number.ToString(); // 
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null then
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label4.Text); // convert the value of the hold_number into a interger
                hold_number = hold_number + 10; // when the 10p is clicked it increases by 10
                label4.Text = hold_number.ToString();
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1_Click 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void txtb_costpercredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")// if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label2.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 2p is clicked then it increases by 1
                label2.Text = hold_number.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit"); // display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label5.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 20p is clicked it increases by 1
                label5.Text = hold_number.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label6.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 50p is clicked then it increase by 1
                label6.Text = hold_number.ToString();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label3.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the 5p is clicked then it increases by 1
                label3.Text = hold_number.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "") // if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label7.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the £1 is clicked then it increases by 1
                label7.Text = hold_number.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtb_costpercredit.Text == "0" || txtb_costpercredit.Text == "")// if the text box (txtb_costpercredit) equals to 0 or null
            {
                MessageBox.Show("You have not set the cost of a credit");// display the message "you have not set the cost of a credit"
            }
            else
            {
                int hold_number = Convert.ToInt32(label8.Text);// convert the value of the hold_number into a interger
                hold_number = hold_number + 1; // when the £2 is clicked it increases by 1
                label8.Text = hold_number.ToString();
            }
        }
    }
}
