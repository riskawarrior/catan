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

        /// <summary>
        /// L�sd �s, csak t�bbet termel.
        /// </summary>
        /// <param name="Dice"></param>
        public override Dictionary<Material, int> Produce(int Dice)
        {

            return null;
        }

    }
}