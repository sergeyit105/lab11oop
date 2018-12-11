using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab11_
{
    class CEmblem
    {
        const int DefaultRadius = 50;
        private Graphics graphics;
        private int _radius;
        public int X { get; set; }
        public int Y { get; set; }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value >= 100 ? 100 : value; _radius = value <= 5 ? 5 : value; }
        }

        public CEmblem(Graphics graphics, int X, int Y, int v)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CEmblem(Graphics graphics, int X, int Y, int Radius, int SideA)
        {
            this.graphics = graphics;
            this.X = 250;
            this.Y = 200;
            this.Radius = DefaultRadius;
        }

        private void Draw(Pen pen)
        {
            Rectangle circl = new Rectangle(X - 110, Y, 2 * Radius, 2 * Radius);
            graphics.DrawEllipse(pen, circl);

            Rectangle cube = new Rectangle(X - 300, Y, Radius * 2, Radius * 2);
            graphics.DrawRectangle(pen, cube);

            double r = (Radius);
            Point p1 = new Point((X - 155) - (int)(r * Math.Cos(Math.PI / 6)), (Y + 132) - (int)(r * Math.PI / 6) - Radius * 2);
            Point p2 = new Point((X - 155)  - (int)(r * Math.Cos(Math.PI / 6)), (Y + 145)  + (int)(r * Math.PI / 3) - Radius * 2);
            Point p3 = new Point((X - 155) + (int)(r * Math.Cos(Math.PI / 6)), (Y + 135) + (int)(r * Math.PI / 7) - Radius * 2);
            Point[] triangle = { p1, p2, p3};
            graphics.DrawPolygon(pen, triangle);
        }

        public void Show()
        {
            Draw(Pens.Violet);
        }
        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }
        public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();


        }
    }
    
}
