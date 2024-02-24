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
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// instance de la classe Controle
        /// </summary>
        private Controle controle;


        public FrmAbsences(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }
    }
}
