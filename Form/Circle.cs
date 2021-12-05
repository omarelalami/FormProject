using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    /// <summary>
    /// La circle c'est un cas particulier de la class ellipse donc elle hérite dans cette class
    /// et pour tout les fonction de la class ellipse c'est appliquent aussi dans la classe circle
    /// </summary>
    class Circle : Ellipse 
    {
        /// <summary>
        /// Constructeur Qui initialise les paramétres
        /// </summary>
        /// <param name="c">Le centre de cercle </param>
        /// <param name="bR"> le point qui définit la distance avec c (LE RAYON)</param>
      public   Circle( Point c ,Point bR) 
            : base (c,bR,bR)
      
        {
            base.c = c;
            base.bR = bR;
            base.ar = bR;
        } 



       
        
    }}
