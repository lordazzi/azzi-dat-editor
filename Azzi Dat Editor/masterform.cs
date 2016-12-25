using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Azzi_Dat_Editor
{
    public partial class masterform : Form
    {
        public masterform()
        {
            InitializeComponent();
        }

        private void open_dat_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Where is Tibia.dat?";
            openfile.Filter = "Tibia.dat|*.dat";
            openfile.ShowDialog();

            //Abrindo o formulário
            datview DatView = new datview(openfile.FileName);
            DatView.MdiParent = this; //passando o parâmetro do arquivo para uma string publica
            DatView.Show();
        }
    }
}
