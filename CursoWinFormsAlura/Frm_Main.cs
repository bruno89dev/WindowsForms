using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWinFormsAlura {
    public partial class Frm_Main : Form {
        public Frm_Main() {
            InitializeComponent();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e) {
            Frm_HelloWorld frm = new Frm_HelloWorld();
            frm.ShowDialog();
        }

        private void Btn_DemonstracaoKey_Click(object sender, EventArgs e) {
            Frm_DemonstracaoKey frm = new Frm_DemonstracaoKey();
            frm.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e) {
            Frm_Mascara frm = new Frm_Mascara();
            frm.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e) {
            Frm_ValidaCPF frm = new Frm_ValidaCPF();
            frm.ShowDialog();
        }

        private void Btn_ValidaCPF_2_Click(object sender, EventArgs e) {
            Frm_ValidaCPF_2 frm = new Frm_ValidaCPF_2();
            frm.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e) {
            Frm_ValidaSenha frm = new Frm_ValidaSenha();
            frm.ShowDialog();
        }
    }
}
