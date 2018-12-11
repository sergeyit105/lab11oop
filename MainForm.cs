using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_
{
    public partial class fMain : Form
    {
        CEmblem[] circles;
        int CircleCount = 0;
        int CurrentCircleIndex;

        public fMain()
        {
            InitializeComponent();
            circles = new CEmblem[100];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (CircleCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;
            circles[CurrentCircleIndex] =
            new CEmblem(graphics, pnMain.Width / 2,
            pnMain.Height / 2, 50);
            circles[CurrentCircleIndex].Show();
            CircleCount++;
            cbCircles.Items.Add("Фігура №" + (CircleCount - 1).ToString());
            cbCircles.SelectedIndex = CircleCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            return;
            circles[CurrentCircleIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
