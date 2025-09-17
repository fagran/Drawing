using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class Point2D
    {
        //Атрибуты класса
        private int x;
        private int y;
        //Конструктор класса
        public Point2D(int x, int y)
        {
            /*this используется для однозначного указания на атрибуты класса так как
            переменные имеют одинаковые имена*/
            this.x = x;
            this.y = y;
        }

        //Методы для получения координат
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        //Методы для изменения координат
        public void addX(int X)
        {
            x+= X;
        }
        public void addY(int Y)
        {
            y+= Y;
        }
    }
}
