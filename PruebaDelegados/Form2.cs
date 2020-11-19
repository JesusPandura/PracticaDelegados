using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDelegados
{
    
    public partial class Form2 : Form
    {
        private Form1 form1;
        public event Delegado ValueUpdate;
        public Form2()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
            string newValue = label1.Text;
            Form1 pp = new Form1();
            ValueUpdate valueArgs = new ValueUpdate(newValue);
            ValueUpdate(this, valueArgs);
        }

      

        
    }
}
