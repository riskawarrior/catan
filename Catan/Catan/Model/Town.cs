using System.Collections.Generic;

namespace Catan.Model
{
    /// <summary>
    /// V�ros. A k�l�nbs�gek fel�ldefini�lva (pl t�bb nyersanyagot termel).
    /// </summary>
    public class Town : Settlement
    {
        /// <summary>
        /// Konstruktor, megh�vja az �s konstruktor�t.
        /// </summary>
        /// <param name="Fields"></param>
        /// <param name="Owner"></param>
        public Town(Hexagon[] Fields, Player Owner):base(Fields,Owner)
        {
            
        }
    }
}