using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Droit
    {
        private Point A;
        private Point B;



       public  Droit(Point A, Point B)
        {

            this.A = A;
            this.B = B;
           
         

        }

 
        public bool EgalitéD(Droit D)
        {
            bool b= false;

            if (A.Egalité(D.A) && B.Egalité(D.B) || A.Egalité(D.B) && B.Egalité(D.A))
                b = true;

            return b;
        }
        public bool Interection(Droit D)
        { bool b = false;

            double a1 = (A.getCordY() - B.getCordY())/(A.getCordX()-B.getCordX());
            double a2=(D.A.getCordY() - D.B.getCordY())/(D.A.getCordX()-D.B.getCordX());
            if (a1 != a2)
                b = true;

            return b;
        }
        public bool Parallélisme(Droit D)
        {
            bool b = false;
            if ((D.A.getCordY() + A.getCordY() == D.B.getCordY() + B.getCordY()) && Interection(D)==false )
                b = true;
            return b;
        }

        public bool Appartenance (Point p)
        { bool b = false;
            if ((p.getCordX() - A.getCordX()) * (A.getCordY() - B.getCordY()) == (p.getCordY() - A.getCordY()) * (A.getCordX() - B.getCordX()))
                 b = true;
            return b;
        }






    }
}
