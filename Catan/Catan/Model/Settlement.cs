using System.Collections.Generic;

namespace Catan.Model
{
    /// <summary>
    /// Telep�l�s objektum.
    /// </summary>
    public class Settlement
    {

        private Hexagon[] Fields;
        /// <summary>
        /// Tulajdonos
        /// </summary>
        private Player Owner;
        public Hexagon m_Hexagon;

        public Settlement()
        {

        }

        public Hexagon[] getFields()
        {
            return Fields;
        }

        /// <summary>
        /// Konstruktor. Inicializ�lja az objektumot.
        /// </summary>
        /// <param name="Fields">A v�rossal szomsz�dos mez�k.</param>
        /// <param name="Owner">Tulajdonos</param>
        public Settlement(Hexagon[] Fields, Player Owner)
        {
            this.Fields = Fields;
            this.Owner = Owner;
        }

        /// <summary>
        /// Az adott dob�snak megfelel�en visszat�r a termelt nyersanyagokkal.
        /// </summary>
        /// <param name="Dice">Kockadob�s eredm�nye mindk�t kock�val</param>
        public Dictionary<Material, int> Produce(int Dice)
        {

            return null;
        }

    }
}