using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Ellipse
    {   /// <summary>
    /// Le centre de l'elipse
    /// </summary>
        protected Point c; 
        /// <summary>
        /// Le point qui défint la hateur de l'llipse
        /// </summary>
        protected Point ar;
        /// <summary>
        /// Le point qui définit la longeur de l'ellipse
        /// </summary>
        protected Point bR;

        /// <summary>
        /// Constructeur Qui intialise les trois paramètres de l'llipse le centre et le petit rayon et le grand
        /// </summary>
        /// <param name="c"></param>
        ///   <param name="ar"></param>
        /// <param name="bR"></param>
        public Ellipse(Point c,Point ar,Point bR)
        {
            
          this.c = c;
          this.ar = ar;
          this.bR = bR;
          
          
           
        }
        /// <summary>
        /// la distance entre le centre d'un ellipse et un autre ellipse en utilisant la methode Distance de la class Point
        /// </summary>
        /// <param name="S"></param>
        /// <returns>  retourne le résultat  de type double  </returns>
        public double Distance(Ellipse S)  
        {
            double d = c.Distance(S.c);
                     
            return d;
        }
        /// <summary>
        /// L'intesection entre deux ellipse si la disatance entre les centre inférieur a la grande rayon 
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public bool Intersection(Ellipse S)
        {
            bool b = false;

            if (S.c.Distance(c) > S.bR.Distance(S.c) + bR.Distance(c))
                b = false;
            else { b = true; }
            return b;
        }
        /// <summary>
        /// L'Egalité de deux ellipse si le centre et le grand rayon egal le gran et le petit egal le petit
        /// </summary>
        /// <returns> true si les deux ellipse sont égaux  snon false </returns>
        public bool Egalité(Ellipse S)
        {
            bool b = false;
            if (S.c.Egalité(c) && S.bR.Egalité(bR) && S.ar.Egalité(ar) )
                b = true;
            return b;
        }
        /// <summary>
        /// La surface de l'ellipse 
        /// </summary>
        /// <returns> retourne la surface de l'ellipse </returns>
        public double Surface() 
        {
            const double Pi = 3.14;
            double s = c.Distance(bR) * c.Distance(ar) * Pi;
            return s;

        } 
        /// <summary>
        /// Le Périmetre de l'ellipse par la relation mathématique
        /// </summary>
        /// <returns> Retourne le résultat en type double</returns>
        public double Périmetre()
        { const double Pi = 3.14;
            double p=Pi*Math.Sqrt( 2*(Math.Pow(c.Distance(ar),2)) +Math.Pow(c.Distance(ar),2));

            return p;


        }  
        /// <summary>
        /// Vérifier si un point contient yn ellipse ou non 
        /// </summary>
        /// <param name="p">Le parametre point c'est qui la fonction vérifier si elle appartient ou non  </param>
        /// <returns> la foncyion retourne true si elle appartient sinon retourne false</returns>
        public bool Apparteneance (Point p)
        {
            bool r = false;
            double a= (ar.getCordX() +bR.getCordX())/2;
            double b=(ar.getCordY() + bR.getCordY()) / 2;
            double X =( Math.Abs((ar.getCordX() - bR.getCordX())))/2;
            double Y= (Math.Abs((ar.getCordY() -bR.getCordY())))/2;

            if ((Math.Pow((p.getCordX() - a) / X, 2)+ Math.Pow((p.getCordY() - b) / Y, 2)) < 1) 
            r = true;





            return r;
        } 
        /// <summary>
        /// La fonction Weight retourne la longeur de l'ellipse utilisant la fonction distance de la class point
        /// c'est par le calcule de la distance entre le centre et le point bR
        /// </summary>
        /// <returns> Retourne le résultat calculer en type double</returns>
        public double Width()
        {
            return 2*c.Distance(bR);
        } 
        /// <summary>
        /// La fonction Height claculer la hateur de l'ellipse ou le deuxienme rayon de l'ellipse 
        /// </summary>
        /// <returns> Retourne le résultat en type double</returns>
        public double  Height()
        {
            return 2*c.Distance(ar);
        }




    }
}
