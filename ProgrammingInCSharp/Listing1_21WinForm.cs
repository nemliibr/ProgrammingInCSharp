using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;

namespace ProgrammingInCSharp.Chapter1
{
    public partial class Listing1_21WinForm : Form
    {
        public Listing1_21WinForm()
        {
            InitializeComponent();
        }

        //Creates the WPF and show it on the WinForm on load event
        private void Listing1_21WinForm_Load(object sender, EventArgs e)
        {
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;

            // Create the WPF UserControl.
            Listing1_21WPF uc = new Listing1_21WPF();
            host.Child = uc;
            this.Controls.Add(host);
        }
    }
}
