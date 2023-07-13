
using WinFormsLib;

namespace CursoWinFormsAlura {
    public partial class Frm_ValidaCPF : Form {
        public Frm_ValidaCPF() {
            InitializeComponent();
        }
        
        private void Btn_Reset_Click(object sender, EventArgs e) {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e) {
            string cpf = Msk_CPF.Text;
            bool validaCPF;
            validaCPF = Cls_Utils.Valida(cpf);
            if (validaCPF == true) {
                Lbl_Resultado.Text = "CPF VÁLIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            } else {
                Lbl_Resultado.Text = "CPF INVÁLIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
