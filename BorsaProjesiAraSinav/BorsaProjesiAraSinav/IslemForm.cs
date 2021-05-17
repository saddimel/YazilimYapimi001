using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesiAraSinav
{
    public partial class IslemForm : Form
    {
        public IslemForm()
        {
            InitializeComponent();
        }

        private void IslemForm_Load(object sender, EventArgs e)
        {
            foreach (string item in Islemler.islemler)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
