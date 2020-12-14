using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UCL_Projekt_1
{
    /// <summary>
    /// Basis formen for programmet. Den står for at skabe den funktionalitet vi forventer i et formsprogram og holde vores sqlconnection.
    /// </summary>
    public partial class BaseForm : Form
    {
        /// <summary>
        /// Connection string til databasen.
        /// </summary>
        private static readonly string connectionString = @"Data Source=den1.mssql8.gear.host;User ID=proevedatabase;Password=Ph0CSw_9V-FS;Database=proevedatabase;";

        /// <summary>
        /// Sqlconnection til databasen.
        /// </summary>
        public static SqlConnection dataConnection = new SqlConnection(connectionString);

        /// <summary>
        /// Den aktive form som vises i programmet. Denne værdi ændres under runtime.
        /// </summary>
        private Form aktiveForm = null;

        /// <summary>
        /// Den aktive knap. Den der er blå.
        /// </summary>
        private Button aktiveButton;

        /// <summary>
        /// Vores constructor til BaseForm
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();

            // Her sættes den aktive knap til at bære boliger knappen
            aktiveButton = Boliger;

            //Her åbnes vores boliger form
            ÅbenNyForm(new BoligerForm(this));
        }


        /// <summary>
        /// Metoden sætter den aktive form til den form som er angivet i parameteret.
        /// </summary>
        /// <param name="form">Den form som skal indlæses</param>
        public void ÅbenNyForm(Form form)
        {
            // Sætter den aktive knap
            SætAktivKnap(form);

            // Hvis der allerede er en aktiv form skal den lukkes før vi åbner en ny.
            if (aktiveForm != null)
            {
                aktiveForm.Close();
            }

            // Den nye form indsættes i panelet som er angivet i Baseform. (Indhold)
            aktiveForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Indhold.Controls.Add(form);
            Indhold.Tag = form;
            form.BringToFront();
            form.Show();
        }

        /// <summary>
        /// Sætter den aktive knap. Metoden ændre på udseendet af knappen
        /// </summary>
        /// <param name="form"></param>
        private void SætAktivKnap(Form form)
        {

            // Vi gemmer den gamle aktive knap
            Button gammelAktivButton = aktiveButton;

            // Vi tjekker på hvilken slags form bliver indlæst og sætter derefter værdierne.
            if (form.GetType() == typeof(BoligerForm))
            {
                if (aktiveButton != Boliger)
                {
                    SætAktivButtonVærdier(gammelAktivButton, Boliger);
                }

            }
            else if (form.GetType() == typeof(MæglerForm))
            {
                if (aktiveButton != Mæglere)
                {
                    SætAktivButtonVærdier(gammelAktivButton, Mæglere);
                }

            }
            else if (form.GetType() == typeof(KunderForm))
            {
                if (aktiveButton != Kunder)
                {
                    SætAktivButtonVærdier(gammelAktivButton, Kunder);
                }

            }
            else if (form.GetType() == typeof(UdskrivingsForm))
            {
                if (aktiveButton != Udskriv)
                {
                    SætAktivButtonVærdier(gammelAktivButton, Udskriv);
                }

            }
        }

        /// <summary>
        /// Sætter værdierne for den nye og gamle knap
        /// </summary>
        /// <param name="gammelAktivButton">Den gamle knap</param>
        /// <param name="button">Den nye knap</param>
        private void SætAktivButtonVærdier(Button gammelAktivButton, Button button)
        {
            Font ikkeAktivFont = button.Font;
            Color ikkeAktivColor = button.BackColor;
            Color ikkeAktivFontColor = button.ForeColor;
            button.Font = aktiveButton.Font;
            button.BackColor = aktiveButton.BackColor;
            button.ForeColor = aktiveButton.ForeColor;
            aktiveButton = button;
            gammelAktivButton.Font = ikkeAktivFont;
            gammelAktivButton.BackColor = ikkeAktivColor;
            gammelAktivButton.ForeColor = ikkeAktivFontColor;
        }

        /// <summary>
        /// Der åbnes en bolig form, hvis der trykkes på boliger knappen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Boliger_Click(object sender, EventArgs e)
        {
            ÅbenNyForm(new BoligerForm(this));
        }

        /// <summary>
        /// Der åbenes en mægler form, hvis der trykkes på mæglere knappen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mægler_Click(object sender, EventArgs e)
        {
            ÅbenNyForm(new MæglerForm(this));
        }

        /// <summary>
        /// Der åbnes en kunde form, hvis der trykkes på kunder knappen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Kunder_Click(object sender, EventArgs e)
        {
            ÅbenNyForm(new KunderForm(this));
        }

        /// <summary>
        /// Der åbnes en udskrivnings form, hvis der trykkes på udskiv knappen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Udskriv_Click(object sender, EventArgs e)
        {
            ÅbenNyForm(new UdskrivingsForm());
        }


        // **FormFunktionalitet**
        //
        // Alt i denne region søger for at vi får funktionalitet, som normalt er tilgængeligt i en form tilbage. 
        // Dette skal til, da vi har fjernet vores form border som normalt står for dette.
        // Vi giver mulighed for at flytte på programmet ved at trykke og holde på den øverste bjælke.
        // Vi giver mulighed for at forstørre og formindske programmet ved at trække på formkanten i bunden.
        // Vi giver mulighed for at bruge kryds knappen til at lukke programmet.
        // Vi giver mulighed for at minimere programmet ved at trykke på den tilhørende knap.
        #region FormFunktionalitet

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        /// <summary>
        /// Søger for at vi kan ændre størrelsen af formen i bunden.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17; //HTBOTTOMRIGHT
                    return;
                }
                else if (cursorPosition.X <= resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)16; //HTBOTTOMLEFT
                    return;
                }
                else if (cursorPosition.X <= resizeArea)
                {
                    m.Result = (IntPtr)10; //HTLEFT
                    return;
                }
                else if (cursorPosition.X >= ClientSize.Width - resizeArea)
                {
                    m.Result = (IntPtr)11; //HTRIGHT
                    return;
                }
                else if (cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)15; //HTBOTTOM
                    return;
                }
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// Lukker programmet, hvis knappen trykkes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Minimere programmet, hvis knappen trykkes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Gør det muligt at flytte på programmet ved at holde på den øverste bjælke.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBar_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

    }
}
