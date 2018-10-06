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
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void OnLinkWikiLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_wiki.Text);
            link_wiki.LinkVisited = true;
        }

        private void OnLinkTannerLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_tanner.Text);
            link_tanner.LinkVisited = true;
        }

        private void OnLinkEfg2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_efg2.Text);
            link_efg2.LinkVisited = true;
        }

        private void OnLinkStackOverflowLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_stackOverflow.Text);
            link_stackOverflow.LinkVisited = true;
        }
    }
}
