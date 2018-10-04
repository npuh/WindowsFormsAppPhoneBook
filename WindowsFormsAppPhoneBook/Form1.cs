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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
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
            Person p = new Person();
            p.FirstName = Name;
            p.LastName = LName;
            p.PhoneNumber = Phone;
            list.Add(p);
            debugOutput("Added!");
        }
    }
}
