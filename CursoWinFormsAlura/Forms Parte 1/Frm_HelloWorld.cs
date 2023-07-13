namespace CursoWinFormsAlura {
    public partial class Frm_HelloWorld : Form {
        public Frm_HelloWorld() {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e) {
            lbl_Titulo.Text = txtBox_ConteudoLabel.Text;            
        }
    }
}