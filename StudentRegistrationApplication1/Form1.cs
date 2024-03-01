using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LastName = Convert.ToString(textBox1.Text);
            string FirstName = Convert.ToString(textBox2.Text);
            string MiddleName = Convert.ToString(textBox3.Text);

            string gender = " ";
            if (radioButton1.Checked == true)
            {
                gender = "Male";

            }
            else if (radioButton2.Checked == true)

            {
                gender = "Female";
            }

            MessageBox.Show("Student name: " + FirstName + MiddleName + LastName +
                "\nGender: " + gender + "\nDate of Birth: " + comboBox1.Text +
                comboBox2.Text + comboBox3.Text + 
                "\nPrograms: " + comboBox4.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day.ToString());
            }

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August",
                                "September", "October", "November", "December" };
            foreach (string i in months)
            {
                comboBox2.Items.Add(i);
            }


            for (int year = 1900; year <= 2024; year++)
            {
                comboBox3.Items.Add(year.ToString());
            }

            string[] programs = { "Bachelor of Science in Computer Science", 
                "Bachelor of Science in Information Technology", 
                "Bachelor of Science in Information Systems", 
                "Bachelor of Science in Computer Engineering" };
            foreach (string i in programs)
            {
                comboBox4.Items.Add(i.ToString());
            }
        }
    }

    }

