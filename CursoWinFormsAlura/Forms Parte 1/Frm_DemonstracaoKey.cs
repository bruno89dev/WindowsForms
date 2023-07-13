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
    public partial class Frm_DemonstracaoKey : Form {
        public Frm_DemonstracaoKey() {
            InitializeComponent();
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e) {
            txt_Msg.AppendText("\r\n" + "Tecla pressionada: " + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Código ASCII: " + e.KeyValue + "\r\n");
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void btn_Reset_Click(object sender, EventArgs e) {
            txt_Input.Text = "";
            txt_Msg.Text = "";
            lbl_Lower.Text = "";
            lbl_Upper.Text = "";
        }
    }
}
