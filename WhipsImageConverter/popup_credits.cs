using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhipsImageConverter
{
    public partial class popup_credits : Form
    {
        public popup_credits()
        {
            InitializeComponent();
        }

        private void link_wiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_wiki.Text);
            link_wiki.LinkVisited = true;
        }

        private void link_tanner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_tanner.Text);
            link_tanner.LinkVisited = true;
        }

        private void link_efg2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_efg2.Text);
            link_efg2.LinkVisited = true;
        }

        private void link_stackOverflow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_stackOverflow.Text);
            link_stackOverflow.LinkVisited = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
