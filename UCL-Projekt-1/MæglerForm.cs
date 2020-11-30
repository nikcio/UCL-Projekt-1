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
    public partial class MæglerForm : Form {

        private BaseForm _baseForm;

        public MæglerForm(BaseForm form) {
            InitializeComponent();
            _baseForm = form;
        }

        private void TilføjMægler_Click(object sender, EventArgs e) {
            _baseForm.OpenChildForm(new RedigerMæglerForm(_baseForm));
        }
    }
}
