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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(string result)
        {
            InitializeComponent();
            mainForm12 = result;
        }

        public string mainForm12 { get; set; }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            resultMain.Text = mainForm12+"%";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int mov;
        int movX;
        int movY;
        private void ResultForm_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ResultForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

            }
        }

        private void ResultForm_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
