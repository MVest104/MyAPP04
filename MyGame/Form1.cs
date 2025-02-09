using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox2.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2f);

            Point[] points = new Point[1000];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, (int)(Math.Tan((double)i / 10) * 10 + 200));
            }
            graphics.DrawLines(pen, points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти?","Подтверждение выхода",MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
