using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class Rectangle
    {
        //Атрибуты класса
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        private Point2D p4;
        //Конструктор класса
        public Rectangle(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
        public Point2D P1
        {
            get
            {
                return p1;
            }
        }
        public Point2D P2
        {
            get
            {
                return p2;
            }
        }
        public Point2D P3
        {
            get
            {
                return p3;
            }
        }
        public Point2D P4
        {
            get
            {
                return p4;
            }
        }
        public void addX(int X)
        {
            p1.addX(X);
            p2.addX(X);
            p3.addX(X);
        }
        public void addY(int Y)
        {
            p1.addY(Y);
            p2.addY(Y);
            p3.addY(Y);
        }
    }
}
