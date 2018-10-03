using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMSG_exhibition
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);
            Width = 3840;
            Height = 2160;

            iniApp();

        }
        private void iniApp()
        {
            
            //wb01.Navigate("http://yspesu.iptime.org");
            wb02.Navigate(" http://yspesu.iptime.org/main/man.do");
            wb03.Navigate("http://square1.iptime.org/");

            wb04.Navigate("http://square1.iptime.org/");
            //=====================================================================
            /*
            ProcessStartInfo startInfo = new ProcessStartInfo();
            

            string target = "http://www.microsoft.com";    //Use no more than one assignment when you test this code. 
                                                           //string target = "ftp://ftp.microsoft.com";
                                                           //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM"; 
            //https://stackoverflow.com/questions/181719/how-do-i-start-a-process-from-c
            try
            {
                //System.Diagnostics.Process.Start(target);
                System.Diagnostics.Process.Start(target,);

            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
            */
            //=====================================================================

        }
        private void picTop_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void wb01_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wb01.Document.Body.Style = "zoom:35%;";
        }
    }
}
