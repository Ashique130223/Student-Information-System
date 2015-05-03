using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Bo;

namespace UI_Desktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StudentBO ss = new StudentBO();

            Student[] st = new Student[200];
            st = ss.getStudentInfo();

            for (int i = 0; ; i++)
            {
                if (st[i] == null)
                    break;
                ListViewItem l = new ListViewItem(st[i].roll);
                l.SubItems.Add(st[i].name);
                l.SubItems.Add(st[i].batch);
                l.SubItems.Add(st[i].address);
                l.SubItems.Add(st[i].year);
                l.SubItems.Add(st[i].term);
                l.SubItems.Add(st[i].contact);
                studentData.Items.Add(l);
            }
        }

       
    }
}
