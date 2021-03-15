using Ders8.Core;
using Ders8.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ders8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number1 number = new Number1 {
                Name = nametxt.Text.ToString(), 
                Surname = surnametxt.Text.ToString(), 
                Age = surnametxt.Text.ToString() };

            XmlVisualitons xmlVisualitons = new XmlVisualitons();
            xmlVisualitons.Write(number);

        }
    }
}
