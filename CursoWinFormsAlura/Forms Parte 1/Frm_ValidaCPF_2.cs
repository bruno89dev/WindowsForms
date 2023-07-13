
using WinFormsLib;

namespace CursoWinFormsAlura {
    public partial class Frm_ValidaCPF_2 : Form {
        public Frm_ValidaCPF_2() {
            InitializeComponent();
        }

        private void LimpaTexto() {
            Msk_CPF.Text = "";
        }

        private void VoltaFocoCaixaTexto() {
            Msk_CPF.Focus();
        }

        private void Btn_Reset_Click(object sender, EventArgs e) {
            LimpaTexto();
            VoltaFocoCaixaTexto();
        }

        private void Btn_Valida_Click(object sender, EventArgs e) {
            string cpf = Msk_CPF.Text;
            bool validaCPF;
            validaCPF = Cls_Utils.Valida(cpf);
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            if (cpf.Length != 11) {
                MessageBox.Show("Digite os 11 dígitos do CPF e tente novamente!", "Caixa de Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaTexto();
                VoltaFocoCaixaTexto();
            } else {
                if (MessageBox.Show("Gostaria de Validar esse CPF?", "Caixa de Diálogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (validaCPF == true) {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaTexto();
                        VoltaFocoCaixaTexto();
                    } else {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpaTexto();
                        VoltaFocoCaixaTexto();
                    }
                } else {
                    MessageBox.Show("Validação cancelada!", "Caixa de Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpaTexto();
                    VoltaFocoCaixaTexto();
                }
            }
        }
    }
}
