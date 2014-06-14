using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WIX_SITE_REVIEW
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String InputURL = tbURL.Text; // [2DO] USE IN EVENT ARGS
            tbLog.Text = "";
            tbLog.Text += "=== EXECUTE ORDER 66 ===\r\n\r\n";
            tbLog.Text += "Starting review for the site " + InputURL;
            
            SiteReview.ReviewSite(Toolbox.FormatURL(tbURL.Text),Toolbox.IsFreeURL(tbURL.Text));
            // statusStrip1.Text = "Execute order 66";
            // webBrowser1.Navigate("http://yoavmag.wix.com/reviewtool?_escaped_fragment_=htmlcontent/c1ofh");           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            HtmlDocument PageCode = webBrowser1.Document;
            HtmlElementCollection CurrentNode = PageCode.All[1].Children;

            foreach (HtmlElement CurrentElement in CurrentNode)
            {
                MessageBox.Show(CurrentElement.OuterHtml);
                MessageBox.Show(PageCode.GetElementById("SITE_STRUCTURE_LinkBar_0").OuterHtml); // SUPPORT MULTIPLE SOCIAL BARS
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new frmMainV2();
            form.Show();

            tsProgress.Maximum = 5;
            tsProgress.Increment(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbLog.Text = "";
            tbLog.Text += "=== URL FORMATTING TEST ===\r\n\r\n\r\n";
            tbLog.Text += "BASE URL IS: " + Toolbox.FormatURL(tbURL.Text).ToUpper() + "\r\n\r\n";

            if (Toolbox.IsFreeURL(tbURL.Text))
            {
                tbLog.Text += "THIS IS A FREE WIX URL";
            }
            else
            {
                tbLog.Text += "THIS IS A DOMAIN ADDRESS";
            }

            
        }
    }
}
