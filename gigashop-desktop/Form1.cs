using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace gigashop_desktop
{
    public partial class GigaShop_Main : Form
    {

        WebClient webClient = new WebClient();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRight, int nTopRect, int nRightRect,
         int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public GigaShop_Main()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 20,20));

        }

        private void GigaShop_Main_Load(object sender, EventArgs e)
        {


        }
    }
}
