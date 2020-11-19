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
    public partial class Form1 : Form
    {
        public event Delegado ValueUpdate;
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            
        }

        public void form2_ValueUpdate(object sender, ValueUpdate e )
       {
            label1.Text = e.newValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar p = new ProgressBar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                form2 = new Form2();
                form2.ValueUpdate += new Delegado(form2_ValueUpdate);
                form2.Show();
                this.timer1.Stop();

            }
        }
    }
}
