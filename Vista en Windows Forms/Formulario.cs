using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_en_Windows_Forms {
    public partial class Formulario : Form {
        public Formulario() {
            InitializeComponent();
        }

        private void editorTexto1_Load(object sender, EventArgs e) {
            editorTexto1.Caja = txt_CajaTexto;
        }
    }
}
