using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPhoneBook
{
    public partial class Form1 : Form
    {
        List<Person> list = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResult.Text = txtResult.Text + strDebugText + Environment.NewLine;
                txtResult.SelectionStart = txtResult.TextLength;
                txtResult.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            foreach (var people in list)
            {
                debugOutput($"People on list: {people.FirstName}, {people.LastName}, {people.PhoneNumber}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string LName = textBox2.Text;
            string Phone = textBox3.Text;
            Person p = new Person
            {
                FirstName = Name,
                LastName = LName,
                PhoneNumber = Phone
            };
            list.Add(p);
            debugOutput("Added!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FirstName = textBox1.Text;
            p.LastName = textBox2.Text;
            p.PhoneNumber = textBox3.Text;

            foreach (var people in list)
            {
             
                    if (people.FirstName == p.FirstName)
                    {
                        debugOutput($"{people.FirstName}, {people.LastName}, {people.PhoneNumber}");
                    }
                    else if (people.LastName == p.LastName)
                    {
                        debugOutput($"{people.FirstName}, {people.LastName}, {people.PhoneNumber}");
                    }
                    else if (people.PhoneNumber == p.PhoneNumber)
                    {
                        debugOutput($"{people.FirstName}, {people.LastName}, {people.PhoneNumber}");
                    }
               
            }                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Person> list2 = new List<Person>();
            list2 = list;
            string Name = textBox1.Text;
            string LName = textBox2.Text;
            Person p = new Person
            {
                FirstName = Name,
                LastName = LName
            };
    
            var remove = list2.Single(r => r.FirstName == Name && r.LastName == LName);
            list2.Remove(remove);
            list2 = list;
            debugOutput("Person removed from list!");
        }

        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtResult.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtResult.Text = "";
            list.Clear();
        }
    }
}
