using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ich hab ken plan wie github funktioniert

namespace IESC
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btn_open_website_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://new.erzgebirgsschwimmcup.de");
        }

        private void btn_web_refresh_Click(object sender, EventArgs e)
        {
            website.Refresh();
        }

        private void btn_web_back_Click(object sender, EventArgs e)
        {
            website.GoBack();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void website_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IsHorizontalScrollbarPresent)
            {
                website.Size = new Size(website.Document.Body.ScrollRectangle.Width, website.Document.Body.ScrollRectangle.Height);
                main.ActiveForm.Size = new Size(website.Document.Body.ScrollRectangle.Width, website.Document.Body.ScrollRectangle.Height);
            }
        }

        public bool IsHorizontalScrollbarPresent
        {
            get
            {
                var widthofScrollableArea = website.Document.Body.ScrollRectangle.Width;
                var widthofControl = website.Document.Window.Size.Width;

                return widthofScrollableArea > widthofControl;
            }
        }

        public int state { get; private set; }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            state = trackBar1.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = state;
        }
    }
}
