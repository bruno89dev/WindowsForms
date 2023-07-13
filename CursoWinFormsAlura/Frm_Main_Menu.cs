
namespace CursoWinFormsAlura {
    public partial class Frm_Main_Menu : Form {
        public Frm_Main_Menu() {
            InitializeComponent();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_HelloWorld frm = new Frm_HelloWorld();
            frm.ShowDialog();
        }

        private void demonstracaoKeyToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_DemonstracaoKey frm = new Frm_DemonstracaoKey();
            frm.ShowDialog();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_Mascara frm = new Frm_Mascara();
            frm.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_ValidaCPF frm = new Frm_ValidaCPF();
            frm.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_ValidaCPF_2 frm = new Frm_ValidaCPF_2();
            frm.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
            Frm_ValidaSenha frm = new Frm_ValidaSenha();
            frm.ShowDialog();
        }
    }
}
