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
    public partial class FrmAuthentification : Form
    {
        Controle controle;

        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }
    }
}
