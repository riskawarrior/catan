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
        public Player Owner { get; set; }

        public Hexagon m_Hexagon;

        public Hexagon[] getFields()
        {
            return Fields;
        }

        public bool IsTown
        {
            get
            {
                return this is Town;
            }
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
        /// L�sd �s, csak t�bbet termel.
        /// </summary>
        /// <param name="Dice"></param>
        public virtual Dictionary<Material, int> Produce(int Dice)
        {

            return null;
        }

    }
}