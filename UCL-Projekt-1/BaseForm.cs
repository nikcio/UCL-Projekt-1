﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCL_Projekt_1 {
    public partial class BaseForm : Form {

        private static readonly string ConnectionString = @"Data Source=den1.mssql8.gear.host;User ID=proevedatabase;Password=Ph0CSw_9V-FS;Database=proevedatabase;";
        public static SqlConnection conn = new SqlConnection(ConnectionString);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public BaseForm() {
            InitializeComponent();
        }

        private Form activeForm = null;
        public void OpenChildForm(Form childForm) {
            if(activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Body.Controls.Add(childForm);
            Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseApp_Click(object sender, EventArgs e) {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void MenuBar_OnMouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea) {
                    m.Result = (IntPtr)17; //HTBOTTOMRIGHT
                    return;
                }
                else if (cursorPosition.X <= resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea) {
                    m.Result = (IntPtr)16; //HTBOTTOMLEFT
                    return;
                }
                else if (cursorPosition.X <= resizeArea) {
                    m.Result = (IntPtr)10; //HTLEFT
                    return;
                }
                else if (cursorPosition.X >= ClientSize.Width - resizeArea) {
                    m.Result = (IntPtr)11; //HTRIGHT
                    return;
                }
                else if (cursorPosition.Y >= ClientSize.Height - resizeArea) {
                    m.Result = (IntPtr)15; //HTBOTTOM
                    return;
                }
            }

            base.WndProc(ref m);
        }

        private void Boliger_Click(object sender, EventArgs e) {
            OpenChildForm(new BoligerForm(this));
        }

        private void Personale_Click(object sender, EventArgs e) {
            OpenChildForm(new MæglerForm(this));
        }

        private void Kunder_Click(object sender, EventArgs e) {
            OpenChildForm(new KunderForm(this));
        }

        private void Udskriv_Click(object sender, EventArgs e) {
            OpenChildForm(new UdskrivingsForm(this));
        }
    }
}
