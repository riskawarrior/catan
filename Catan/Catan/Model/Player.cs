using System.Collections.Generic;
namespace Catan.Model
{


    /// <summary>
    /// J�t�kos oszt�ly. Tartalmazza a j�t�kosok be�ll�t�sait.
    /// </summary>
    public class Player
    {

        /// <summary>
        /// Csak getter.
        /// </summary>
        public PlayerColor Color
        {
            //read property
            get;
            //write property
            set;
        }
        /// <summary>
        /// �v� a leghosszabb �t?
        /// </summary>
        private bool LongestRoad;
        /// <summary>
        /// A j�t�kos nyersanyagk�szlete. Csak getter.
        /// </summary>
        public Dictionary<Material, int> Materials
        {
            //read property
            get;
            //write property
            set;
        }
        /// <summary>
        /// Csak getter.
        /// </summary>
        public string Name
        {
            //read property
            get; 
            //write property
            set;
        }
        /// <summary>
        /// Telep�l�sek list�ja.
        /// </summary>
        private Settlement[] Settlements;
        public Material m_Material;
        public PlayerColor m_PlayerColor;
        public Settlement m_Settlement;

        public Player()
        {

        }

        public virtual void Dispose()
        {

        }

        /// <summary>
        /// Konstruktor. Inicializ�lja az objektumot.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Color"></param>
        public Player(string Name, PlayerColor Color)
        {

        }

        /// <summary>
        /// Hozz�adja a paramterben l�v� nyersanyagokat a j�t�kos k�szlet�hez.
        /// </summary>
        /// <param name="Materials"></param>
        public void AddMaterials(Dictionary<Material, int> Materials)
        {

        }

        /// <summary>
        /// Hozz�ad egy �j telep�l�st vagy v�rost.
        /// </summary>
        /// <param name="Settlement"></param>
        public void AddSettlement(Settlement Settlement)
        {

        }

        /// <summary>
        /// Levonja a sz�ks�ges nyersanyagokat majd visszat�r �nmag�val. Ha nincs el�g
        /// nyersanyag kiv�telt dob.
        /// </summary>
        public Player BuildRoad()
        {

            return null;
        }

        /// <summary>
        /// K�sz�t egy �j telep�l�st. Hozz�adja a list�j�hoz, levonja a nyersanyagot, majd
        /// visszat�r vele. Ha nincs el�g nyersanyag akkor kiv�telt dob.
        /// </summary>
        public Settlement BuildSettlement()
        {

            return null;
        }

        /// <summary>
        /// Az adott dob�snak megfelel�en a nyersanyagok betakar�t�sra ker�lnek.
        /// </summary>
        /// <param name="Dice">Kockadob�s</param>
        public void CollectMaterials(int Dice)
        {

        }

        /// <summary>
        /// Betakar�tja a kezd� nyersanyagokat (a v�rossal szomsz�dos mez�kr�l 1-1 => town.
        /// produce / 2).
        /// </summary>
        public void CollectStarterMaterials()
        {

        }

        /// <summary>
        /// A j�t�kos pontsz�ma.
        /// </summary>
        public int GetPoints()
        {

            return 0;
        }

        /// <summary>
        /// Elvesz megadott sz�m� �s t�pus� nyersanyagot a j�t�kos k�szlet�b�l. Negat�v
        /// �rt�kn�l kiv�tel!
        /// </summary>
        /// <param name="Materials"></param>
        public void RemoveMaterials(Dictionary<Material, int> Materials)
        {

        }

        /// <summary>
        /// Igazra �ll�tja a leghosszabb utat
        /// </summary>
        public void SetLongestRoad()
        {

        }

        /// <summary>
        /// Hamisra �ll�tja a LongestRoad-ot.
        /// </summary>
        public void UnsetLongestRoad()
        {

        }

        /// <summary>
        /// Egy telep�l�st v�ross� alak�t. Ha nincs el�g nyersanyag, akkor kiv�telt dob. Ha
        /// a param�ter m�r v�ros akkor is. :)
        /// </summary>
        /// <param name="Settlement"></param>
        public void UpgradeSettlement(Settlement Settlement)
        {

        }

    }
}