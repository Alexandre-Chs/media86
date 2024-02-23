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

namespace media
{
    public partial class FrmPersonnel : Form
    {
        private Controle controle;
        public FrmPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }
    }
}
