namespace Catan.Model
{

    /// <summary>
    /// A t�rk�p oszt�ly.
    /// </summary>
    public class Map
    {

        /// <summary>
        /// A t�rk�p
        /// </summary>
        public Hexagon[][] map
        {
            //read property
            get;
            //write property
            set;
        }
        public Hexagon m_Hexagon;

        public virtual void Dispose()
        {

        }

        /// <summary>
        /// Konstruktor. Elk�sz�ti a t�rk�pet.
        /// </summary>
        public Map()
        {

        }

        /// <summary>
        /// Visszaadja a leghosszabb �t hossz�t.
        /// </summary>
        public int LongestRoadLength()
        {

            return 0;
        }

        /// <summary>
        /// Visszaadja a leghosszabb �t tulajdonos�t
        /// </summary>
        public Player LongestRoadOwner()
        {

            return null;
        }

    }
}