using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseline
{
    public partial class SaveFhpFileDialog : Form
    {
        public SaveFhpFileDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The name of the binary *.fhp file where the data will be stored.
        /// </summary>
        public string Filename
        {
            get { return textBoxFilename.Text + ".fhp"; }
        }
    }
}