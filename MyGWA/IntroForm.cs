using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace MyGWA
{
    public partial class IntroForm : Form
    {

       
        public IntroForm()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainLoad.Width += 3;
            if(mainLoad.Width >= 500)
            {
                timer1.Stop();
                SubjectForm subjectForm = new SubjectForm();
                subjectForm.Show();
                this.Hide();
            }
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
        
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
          
        }
    }
}
