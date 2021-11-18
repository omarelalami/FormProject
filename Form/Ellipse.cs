using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Ellipse
    {
        protected Point c;
        protected Point ar;
        protected Point bR;
        protected Droit r;
        protected Droit R;

       public Ellipse(Droit r ,Droit R,Point c,Point ar,Point bR)
        { this.c = c;
          this.ar = ar;
          this.bR = bR;
           r = new Droit(c, ar);
           R = new Droit(c, bR);
          this.r = r ;
          this.R = R;
           
        }

    public double Distance(Ellipse S)
        {
            double d = c.Distance(S.c);
                     
            return d;
        }
     public bool Intersection(Ellipse S)
        {
            bool b = false;

            if (S.c.Distance(c) > S.bR.Distance(S.c) + bR.Distance(c))
                b = false;
            else { b = true; }
            return b;
        }

    public bool Egalité(Ellipse S)
        {
            bool b = false;
            if (S.r.EgalitéD(r) && S.R.EgalitéD(R))
                b = true;
            return b;
        }

        public double Surface()
        {
            const double Pi = 3.14;
            double s = c.Distance(bR) * c.Distance(ar) * Pi;
            return s;

        }

        public double Périmetre()
        { const double Pi = 3.14;
            double p=Pi*Math.Sqrt( 2*(Math.Pow(c.Distance(ar),2)) +Math.Pow(c.Distance(ar),2));

            return p;


        }


        

 
    }
}
