using System;
using System.Collections.Generic;
namespace Catan.Model
{
    public class NotEnoughMaterialsException : System.Exception
    {
        public NotEnoughMaterialsException() : base() { }
        public NotEnoughMaterialsException(string message) : base(message) { }
        public NotEnoughMaterialsException(string message, System.Exception inner) : base(message, inner) { }

        protected NotEnoughMaterialsException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }

    public class ItsAlreadyTownException : System.Exception
    {
        public ItsAlreadyTownException() : base() { }
        public ItsAlreadyTownException(string message) : base(message) { }
        public ItsAlreadyTownException(string message, System.Exception inner) : base(message, inner) { }

        protected ItsAlreadyTownException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }

	/// <summary>
	/// J�t�kos oszt�ly. Tartalmazza a j�t�kosok be�ll�t�sait.
	/// </summary>
	public class Player
	{
		public Dictionary<Material, TradeItem> TradeItems { get; protected set; }

		public int Gold { get; set; }

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
		private List<Settlement> Settlements;
		public Material m_Material;
		public PlayerColor m_PlayerColor;
		public Settlement m_Settlement;

        public Player(string name, PlayerColor pc)
		{
            Name = name;
            m_PlayerColor = pc;
            Materials = new Dictionary<Material, int>();
            Settlements = new List<Settlement>();
		}

		/// <summary>
		/// Konstruktor. Inicializ�lja az objektumot.
		/// </summary>
		/// <param name="Name"></param>
		/// <param name="Color"></param>
		public Player(string name, PlayerColor color)
		{
			Name = name;
			Color = color;
			TradeItems = new Dictionary<Material, TradeItem>();
			Gold = 1000;
		}

		/// <summary>
		/// Hozz�adja a paramterben l�v� nyersanyagokat a j�t�kos k�szlet�hez.
		/// </summary>
		/// <param name="Materials"></param>
		public void AddMaterials(Dictionary<Material, int> mats)
		{
            foreach (KeyValuePair<Material, int> ms in mats)
            {
                if (Materials.ContainsKey(ms.Key))
                {
                    Materials[ms.Key] += ms.Value;
                }
                else
                {
                    Materials.Add(ms.Key, ms.Value);
                }
            }
		}

		/// <summary>
		/// Hozz�ad egy �j telep�l�st vagy v�rost.
		/// </summary>
		/// <param name="Settlement"></param>
		public void AddSettlement(Settlement Settlement)
		{
            Settlements.Add(Settlement);
		}

		public void AddTradeItem(int price, int quantity, Material material)
		{
			TradeItems.Add(material, new TradeItem { Material = material, Player = this, Price = price, Quantity = quantity });
		}

		/// <summary>
		/// Keresked�s m�s j�t�kosokkal
		/// </summary>
		public void TradeWithPlayer(Player player, int quantity, Material material)
		{
			if (player == null)
				throw new ArgumentNullException("player");

			if (player == this)
				throw new Exception("Saj�t mag�val nem kereskedhet a j�t�kos!");

			TradeItem item;
			if (TradeItems.TryGetValue(material, out item))
			{
				item.Quantity -= quantity;
				Gold += quantity * item.Price;
				player.Gold -= quantity * item.Price;
			}
		}

		/// <summary>
		/// Levonja a sz�ks�ges nyersanyagokat majd visszat�r �nmag�val. Ha nincs el�g
		/// nyersanyag kiv�telt dob.
		/// </summary>
		public Player BuildRoad()
		{
            if (Materials[Material.Wood] > 0 && Materials[Material.Clay] > 0)
            {
                Materials[Material.Wood]--;
                Materials[Material.Clay]--;
            }
            else
            {
                throw new NotEnoughMaterialsException();
            }
            return this;
		}

		/// <summary>
		/// K�sz�t egy �j telep�l�st. Hozz�adja a list�j�hoz, levonja a nyersanyagot, majd
		/// visszat�r vele. Ha nincs el�g nyersanyag akkor kiv�telt dob.
		/// </summary>
		public Settlement BuildSettlement()
		{
            Settlement set = new Settlement();
            if (Materials[Material.Wood] > 0 && Materials[Material.Clay] > 0 && Materials[Material.Wheat] > 0 && Materials[Material.Wool] > 0)
            {
                Materials[Material.Wood]--;
                Materials[Material.Clay]--;
                Materials[Material.Wheat]--;
                Materials[Material.Wool]--;
                Settlements.Add(set);
            }
            else
            {
                throw new NotEnoughMaterialsException();
            }
            return set;
		}

		/// <summary>
		/// Az adott dob�snak megfelel�en a nyersanyagok betakar�t�sra ker�lnek.
		/// </summary>
		/// <param name="Dice">Kockadob�s</param>
		public void CollectMaterials(int Dice)
		{
            foreach (Settlement s in Settlements)
            {
                Dictionary<Material, int> settlemetMaterial = s.Produce(Dice);
                foreach (KeyValuePair<Material, int> ms in settlemetMaterial)
                {
                    if (Materials.ContainsKey(ms.Key))
                    {
                        Materials[ms.Key] += ms.Value;
                    }
                    else
                    {
                        Materials.Add(ms.Key, ms.Value);
                    }
                }
            }
		}

		/// <summary>
		/// Betakar�tja a kezd� nyersanyagokat (a v�rossal szomsz�dos mez�kr�l 1-1 => town.
		/// produce / 2).
		/// </summary>
		public void CollectStarterMaterials()
		{
            for (int i = 2; i <= 12; i++)
            {
                CollectMaterials(i);
            }
		}

		/// <summary>
		/// A j�t�kos pontsz�ma.
		/// </summary>
		public int GetPoints()
		{
            int point = 0;
            foreach (Settlement s in Settlements)
            {
                if (s.GetType().ToString() == "Settlement")
                {
                    point++;
                }
                else
                {
                    point += 2;
                }
            }
            if (LongestRoad)
            {
                point += 2;
            }
            return point;
		}

		/// <summary>
		/// Elvesz megadott sz�m� �s t�pus� nyersanyagot a j�t�kos k�szlet�b�l. Negat�v
		/// �rt�kn�l kiv�tel!
		/// </summary>
		/// <param name="Materials"></param>
		public void RemoveMaterials(Dictionary<Material, int> mats)
		{
            foreach (KeyValuePair<Material, int> ms in mats)
            {
                if (Materials.ContainsKey(ms.Key) && Materials[ms.Key] >= ms.Value)
                {
                    Materials[ms.Key] -= ms.Value;
                }
                else
                {
                    throw new NotEnoughMaterialsException();
                }
            }
		}

		/// <summary>
		/// Igazra �ll�tja a leghosszabb utat
		/// </summary>
		public void SetLongestRoad()
		{
            LongestRoad = true;
		}

		/// <summary>
		/// Hamisra �ll�tja a LongestRoad-ot.
		/// </summary>
		public void UnsetLongestRoad()
		{
            LongestRoad = false;
		}

		/// <summary>
		/// Egy telep�l�st v�ross� alak�t. Ha nincs el�g nyersanyag, akkor kiv�telt dob. Ha
		/// a param�ter m�r v�ros akkor is. :)
		/// </summary>
		/// <param name="Settlement"></param>
		public void UpgradeSettlement(Settlement settlement)
		{
            if (settlement.GetType().ToString() != "Town")
            {
                if (Materials[Material.Iron] >= 3 && Materials[Material.Wheat] >= 2)
                {
                    Materials[Material.Wheat] -= 3;
                    Materials[Material.Iron] -= 2;
                    Town town = new Town(settlement.getFields(), this);
                    Settlements.Remove(settlement);
                    Settlements.Add(town);
                }
                else
                {
                    throw new NotEnoughMaterialsException();
                }
            }
            else
            {
                throw new ItsAlreadyTownException();
            }
		}

	}
}