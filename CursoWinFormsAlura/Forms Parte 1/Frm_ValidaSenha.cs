using static WinFormsLib.Cls_Utils;

namespace CursoWinFormsAlura {
    public partial class Frm_ValidaSenha : Form {

        bool verSenhaTxt = false;

        public Frm_ValidaSenha() {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e) {
            txt_Senha.Text = "";
            lbl_Resultado.Text = "";
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e) {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txt_Senha.Text);
            lbl_Resultado.Text = forca.ToString();

            if (lbl_Resultado.Text == "Inaceitavel" || lbl_Resultado.Text == "Fraca") {
                lbl_Resultado.ForeColor = Color.Red;
            } else if (lbl_Resultado.Text == "Aceitavel") {
                lbl_Resultado.ForeColor = Color.Blue;
            } else {
                lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void btn_MostraSenha_Click(object sender, EventArgs e) {
            if (verSenhaTxt == false) {
                txt_Senha.PasswordChar = '\0';
                verSenhaTxt = true;
                btn_MostraSenha.Text = "Ocultar Senha";
            } else {
                txt_Senha.PasswordChar = '*';
                verSenhaTxt = false;
                btn_MostraSenha.Text = "Mostrar Senha";
            }
        }
    }
}

