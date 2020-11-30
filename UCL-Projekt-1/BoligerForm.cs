using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCL_Projekt_1 {
    public partial class BoligerForm : Form {
        private BaseForm _baseForm;

        public BoligerForm(BaseForm form) {
            InitializeComponent();
            _baseForm = form;
        }

        private void TilføjBolig_Click(object sender, EventArgs e) {
            _baseForm.OpenChildForm(new RedigerBoligerForm(_baseForm));
        }
    }
}
