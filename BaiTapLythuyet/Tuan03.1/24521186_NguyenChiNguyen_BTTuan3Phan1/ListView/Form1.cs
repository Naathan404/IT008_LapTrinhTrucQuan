using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbListBoxViewSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbListBoxViewSelection.SelectedIndex)
            {
                case 0:
                    lsVListView.View = View.LargeIcon;
                    break;
                case 1:
                    lsVListView.View = View.SmallIcon;
                    break;
                case 2:
                    lsVListView.View = View.List;
                    break;
                case 3:
                    lsVListView.View = View.Tile;
                    break;
                default:
                    lsVListView.View = View.Details;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
