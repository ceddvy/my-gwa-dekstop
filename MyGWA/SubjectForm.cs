using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGWA
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }
        int mov;
        int movX;
        int movY;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrack.Text = trackBar1.Value.ToString();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(lblTrack.Text);
            creatingField.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!checkTracker())
            {
                MainForm12 mainForm = new MainForm12(lblTrack.Text);
                mainForm.Show();
                this.Hide();
            }



        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTrack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) {
                e.Handled = true;
            }
            


        }

        public bool checkTracker()
        {
            bool isNull = false;
            int counter = int.Parse(lblTrack.Text);

            try
            {
                if (counter > 12)
                {
                    isNull = true;
                    MessageBox.Show("You have to many subjects!");
                }
                if (counter < 2)
                {
                    isNull = true;
                    MessageBox.Show("Invalid Input! Starting number is 2.");
                }

            }
            catch (Exception)
            {

            }
            return isNull;
        }

        public bool checkTracker1()
        {
            bool isNull = false;

            try
            {
                if (lblTrack.TextLength > 2)
                {
                    isNull = true;
                    MessageBox.Show("Only Two digits is accepted");
                    lblTrack.Text = "2";
                }
            }
            catch (Exception)
            {

            }
            return isNull;
        }

        private void lblTrack_TextChanged(object sender, EventArgs e)
        {
            if (!checkTracker1())
            {

            }
        }

        private void lblTrack_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!checkTracker())
                {
                    MainForm12 mainForm = new MainForm12(lblTrack.Text);
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void SubjectForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void SubjectForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

            }
        }

        private void SubjectForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
