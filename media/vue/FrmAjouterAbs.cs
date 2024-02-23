using media.controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media.vue
{
    public partial class FrmAjouterAbs : Form
    {
        private Controle controle;

        public FrmAjouterAbs(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }
    }
}
