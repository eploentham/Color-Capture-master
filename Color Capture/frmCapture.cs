using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Capture
{
    public partial class frmCapture : Form
    {
        private List<ColorControls> colorControlsList;
        public frmCapture()
        {
            InitializeComponent();
            colorControlsList = new List<ColorControls>();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            MouseHook.Start();
            MouseHook.MouseAction += MouseHook_MouseAction;
        }

        private void MouseHook_MouseAction(object sender, MouseHook.RawMouseEventArgs e)
        {
            Console.WriteLine("mouse act" + e.Message);
            Color clcolor = GetColorAt(e.Point.x, e.Point.y);
            picSelColor.BackColor = clcolor;
            string htmlcol = ColorTranslator.ToHtml(Color.FromArgb(clcolor.ToArgb()));
            txtHtmlColor.Text = htmlcol;
            if (e.Message == MouseHook.MouseMessages.WM_LBUTTONDOWN)
            {
                Console.WriteLine("mouse click " + e.Point.x + ":" + e.Point.y);
                MouseHook.Stop();
                MouseHook.MouseAction -= MouseHook_MouseAction;
                addColor(clcolor);
            }
        }
        private void addColor(Color selcol)
        {
            var ncc = new ColorControls(selcol, colorControlsList.Count);
            ncc.DeleteClick += Ncc_DeleteClick;
            colorControlsList.Add(ncc);
            drawTable();
        }
        private void drawTable()
        {
            int row = 0;
            SuspendLayout();
            tblColors.Controls.Clear();
            tblColors.RowCount = colorControlsList.Count;
            for (int i = colorControlsList.Count - 1; i >= 0; i--)
            {
                var cc = colorControlsList[i];
                tblColors.Controls.Add(cc.picColor, 0, row);
                tblColors.Controls.Add(cc.htmlColor, 1, row);
                tblColors.Controls.Add(cc.picCopy, 2, row);
                tblColors.Controls.Add(cc.picDelete, 3, row);
                cc.Refresh();
                row++;
            }

            tblColors.Refresh();

            ResumeLayout();

            Refresh();
        }
        private void Ncc_DeleteClick(object sender, EventArgs e)
        {
            var cc = (ColorControls)sender;
            colorControlsList.Remove(cc);
            drawTable();
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private void ntfColorCapture_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ntfColorCapture_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void frmCapture_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                ntfColorCapture.Visible = true;
                this.ShowInTaskbar = false;
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                ntfColorCapture.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
        private void picBtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHtmlColor.Text);
        }
        internal class ColorControls
        {
            public PictureBox picColor { get; set; }
            public TextBox htmlColor { get; set; }
            public PictureBox picCopy { get; set; }
            public PictureBox picDelete { get; set; }
            public int Idx { get; set; }
            public ColorControls() { }
            public event EventHandler DeleteClick = delegate { };
            public ColorControls(Color htmlcolor, int idx)
            {
                Idx = idx;
                picColor = new PictureBox() { Name = "picSelColor" + idx.ToString(), Size = new Size(20, 20), BackColor = htmlcolor,BorderStyle=BorderStyle.FixedSingle };
                picCopy = new PictureBox() { Name = "picBtnCopy" + idx.ToString(), Size = new Size(20, 20), SizeMode = PictureBoxSizeMode.Zoom, Image = Properties.Resources.copy1_32 };
                picDelete = new PictureBox() { Name = "picBtnDelete" + idx.ToString(), Size = new Size(20, 20), SizeMode = PictureBoxSizeMode.Zoom, Image = Properties.Resources.delete121_32 };
                htmlColor = new TextBox() { Name = "txtHtmlColor" + idx.ToString(), Size = new Size(148, 20), Text = ColorTranslator.ToHtml(Color.FromArgb(htmlcolor.ToArgb())), ReadOnly = true };
                picCopy.Click += PicCopy_Click;
                picDelete.Click += PicDelete_Click;
            }

            private void PicDelete_Click(object sender, EventArgs e)
            {
                DeleteClick(this, new EventArgs());
            }

            private void PicCopy_Click(object sender, EventArgs e)
            {
                Clipboard.SetText(htmlColor.Text);
            }

            public void Refresh()
            {

                picColor.Refresh();
                picColor.Update();
                picCopy.Update();
                picCopy.Refresh();
                picDelete.Refresh();
                picCopy.Update();
            }
        }
        private bool frmExtended = false;
        private void picBtnShowHide_Click(object sender, EventArgs e)
        {
            int maxHeight = 300;
            int minHeight = 85;
            if (!frmExtended)
            {
                picBtnShowHide.Image = Properties.Resources.up1;
                this.Height = maxHeight;
                frmExtended = true;
            }else
            {
                picBtnShowHide.Image = Properties.Resources.down1;
                this.Height = minHeight;
                frmExtended = false;
            }
        }

        private void picBtnShowHide_MouseHover(object sender, EventArgs e)
        {
            if (!frmExtended) picBtnShowHide.Image = Properties.Resources.down2;
            else picBtnShowHide.Image = Properties.Resources.up2;
        }

        private void frmCapture_Load(object sender, EventArgs e)
        {

        }
    }
}
