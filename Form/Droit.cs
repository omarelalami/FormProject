using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Droit
    {   /// <summary>
    /// Le premier pointe de droite
    /// </summary>
        private Point A;
        /// <summary>
        /// La dexieme point de droit
        /// </summary>
        private Point B;


       /// <summary>
       /// LE CONSTRUCTEUR INTIALISE LES DEUX POINT
       /// </summary>
       /// <param name="A"></param>
       /// <param name="B"></param>
       public  Droit(Point A, Point B) {

            this.A = A;
            this.B = B;
           
         

        }
        /// <summary>
        /// La fontion vérifier si le droit en cours égale un autre droite et par la comparaison des point
        /// </summary>
        /// <param name="D"> le droit qui la fonction compare </param>
        /// <returns> si les droit sont égaux alors retourne true sinon false</returns>
        public bool EgalitéD(Droit D)
        {
            bool b= false;

            
            double cof1 = (B.getCordY() - A.getCordY() )/( B.getCordX() - A.getCordX());
            double cof2 = (D.B.getCordX() - D.A.getCordX()) / (D.B.getCordX() - D.A.getCordX());
            double b1 = B.getCordY() - cof1 * B.getCordX();
            double b2 = D.B.getCordY() - cof1 * D.B.getCordX();
            if ((cof1==cof2) && (b1==b2))
                b = true;

            return b;
        }    
        /// <summary>
        /// Pour vérifier L'intersection de deux droit et pour ça en utilise une formule qui vérifier cette opération
        /// </summary>
        /// <param name="D"> Le droit qui véifier si il ya un intersection avec le droit en cours</param>
        /// <returns> retourne True si il y a un intersection sino false</returns>
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
        }///

        public double Longeur()
        {
            return A.Distance(B);
        } 





    }
}
