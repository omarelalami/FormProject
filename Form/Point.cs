using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
 
    class Point
    {
        private double x;
        private double y;
        private double z;
        public Point(double x,double y) {
            this.x = x;
            this.y = y;
        } 

        public Point(double  x,double  y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }

        
       public  bool Egalité(Point p)
        {
            bool m = false;
            if (x == p.x && y == p.y && z == p.z)
                m = true;


            return m;
        }
        public double Distance (Point p)

        {
            double d;
            double xd = Math.Pow((p.x - x),2);
            double yd = Math.Pow((p.y - y),2);
            double zd = Math.Pow((p.z - z),2);
            d=Math.Sqrt(xd-yd-zd);


            return d;
        }

        public double getCordX()
        {
            return this.x ;
        }
        public double getCordY()
        { return this.y; }
        
        public double getCordZ()
        {
           return  this.z;

        }

    }
}
