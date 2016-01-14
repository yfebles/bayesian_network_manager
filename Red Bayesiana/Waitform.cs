using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Red_Bayesiana
{
    public partial class Waitform : Form
    {
        public Waitform()
        {
            InitializeComponent();
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Refresh();
        }

        private int i = 0;
        Random r=new Random();
        Pen pen =new Pen(new SolidBrush(Color.CornflowerBlue));
        private void Waitform_Paint(object sender, PaintEventArgs e)
        {
            if (i == 1000)
            {
                i = 0;
                return;
            }
            e.Graphics.FillEllipse(new SolidBrush(Color.CornflowerBlue), r.Next(25,this.Width),r.Next(0,Height),r.Next(10,35),r.Next(10,35));
            i++;
        }

        private void Waitform_Load(object sender, EventArgs e)
        {
        }


        
    }
}
