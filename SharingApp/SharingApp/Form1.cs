using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharingApp
{
    public partial class Form1 : Form
    {
        PublicShare4 publicShare;

        public Form1()
        {
            InitializeComponent();
            InitMembers();
        }

        public void InitMembers()
        {
            publicShare = new PublicShare4();
        }

        private void btnShareFb_Click(object sender, EventArgs e)
        {
            publicShare.Share(1, txtText.Text);
        }

        private void btnShareTwitter_Click(object sender, EventArgs e)
        {
            publicShare.Share(2, txtText.Text);
        }

        private void btnShareVK_Click(object sender, EventArgs e)
        {
            publicShare.Share(3, txtText.Text);
        }

        private void btnShareLinkedin_Click(object sender, EventArgs e)
        {
            publicShare.Share(4, txtText.Text);
        }
    }
}
