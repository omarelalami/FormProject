using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Ellipse
    {
        Point C;
        Point A;
        Point B;
        Droit r;
        Droit R;
        Ellipse(Droit r,Droit R) {

            r = new Droit(C, A);
            R = new Droit(C, B);
            this.r = r;
            this.R = R;
           
            }



        

 
    }
}
