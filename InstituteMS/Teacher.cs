using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteMS
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        Teachers tea = new Teachers();
        private void button1_Click(object sender, EventArgs e)
        {
            //tea.teaID =int.Parse( teaID.Text);
            //tea.teaFName = teaFName.Text;
            //tea.teaLName = teaLName.Text;
            //tea.teaContact = teaContact.Text;
            //tea.teaNIC = teaNIC.Text;
            //tea.teaAdd1 = teaAdd1.Text;
            //tea.teaAdd2 = teaAdd2.Text;
            //tea.teaAdd3 = teaAdd3.Text;
            //tea.teaEmail = teaEmail.Text;
            //tea.teaSubject = teaSubject.Text;
            setTextBoxValues();
            tea.RegisterTeacher();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTextBoxValues();
            tea.ModifyTeacher();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void setTextBoxValues() {
            tea.setTeacherValues(int.Parse(teaID.Text), teaFName.Text, teaLName.Text, teaContact.Text, teaNIC.Text, teaAdd1.Text, teaAdd2.Text, teaAdd3.Text, teaEmail.Text, teaSubject.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teachers form = new Teachers();
            teaID.Text = form.SearchTeacher2().Item1; 
            tea.teaID = int.Parse(teaID.Text);
            tea.SearchTeacher();
            
        }
    }
}
