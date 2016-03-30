using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackNight
{
    public partial class guiIncial : Form
    {
        public guiIncial()
        {
            InitializeComponent();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            guiCompra gI = new guiCompra();
            gI.ShowDialog();
            this.Close();
        }

        private void buttonGerenciar_Click(object sender, EventArgs e)
        {
            GuiGerencia gG = new GuiGerencia();
            gG.ShowDialog();
            this.Close();
        }
    }
}
