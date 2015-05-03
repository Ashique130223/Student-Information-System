using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Bo;
using System.Windows.Forms;

namespace UI_Desktop
{
    public partial class Form1 : Form
    {
        StudentBO sbo =new StudentBO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student st = new Student();
                st.roll = textRoll.Text;
                st.name = textName.Text;
                st.batch = textBatch.Text;
                st.address = textAddress.Text;
                st.year = comboYear.Text;
                st.term = comboTerm.Text;
                st.contact = textContct.Text;

                sbo.saveStudentInfo(st);

                textRoll.Clear();
                textName.Clear();
                textBatch.Clear();
                textAddress.Clear();
                textContct.Clear();
                MessageBox.Show("Saved Successfully. Go for next please.");
            }
            catch (Exception e1)
            {
                MessageBox.Show("Sorry there is an ERROR !!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Form2 table = new Form2();
            table.Show();
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTerm_Click(object sender, EventArgs e)
        {

        }

        private void textContct_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContct_Click(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblBatch_Click(object sender, EventArgs e)
        {

        }

        private void textBatch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblRoll_Click(object sender, EventArgs e)
        {

        }

        private void textRoll_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
