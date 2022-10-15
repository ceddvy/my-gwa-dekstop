using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGWA
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        ToolTip tool = new ToolTip();

       

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.facebook.com/sequin.bernardo/");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/jcb_johncedric");
        }

        private void btnIG_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/_ichi.ceddy_/");
        }

        private void btnFacebook_MouseHover(object sender, EventArgs e)
        {
            btnFacebook.BackColor = System.Drawing.SystemColors.WindowFrame;
            tool.SetToolTip(this.btnFacebook, "Visit or Dm Me at Facebook");
        }

        private void btnFacebook_MouseLeave(object sender, EventArgs e)
        {
            btnFacebook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void btnTwitter_MouseHover(object sender, EventArgs e)
        {
            btnTwitter.BackColor = System.Drawing.SystemColors.WindowFrame;
            tool.SetToolTip(this.btnTwitter, "Visit or Dm Me at Twitter");
        }

        private void btnTwitter_MouseLeave(object sender, EventArgs e)
        {
            btnTwitter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void btnIG_MouseHover(object sender, EventArgs e)
        {
            btnIG.BackColor = System.Drawing.SystemColors.WindowFrame;
            tool.SetToolTip(this.btnIG, "Visit or Dm Me at Instagram");
        }

        private void btnIG_MouseLeave(object sender, EventArgs e)
        {
            btnIG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
