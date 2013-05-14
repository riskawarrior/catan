using System;
using System.Collections.Generic;

namespace Catan.Model
{
	public struct Hexid
	{
		int column;
		int row;
		public Hexid(int c, int r)
		{
			column = c;
			row = r;
		}
        public int getCol()
        {
            return column;
        }
        public int getRow()
        {
            return row;
        }
	}
	/// <summary>
	/// A t�rk�p alkot�eleme.
	/// </summary>
	public class Hexagon : IDisposable
	{
		public List<Hexagon> Neighbours { get; protected set; }

		/// <summary>
		/// A rabl� itt tal�lhat�?
		/// </summary>
		public bool HasRobber
		{
			//read property
			get;
			//write property
			set;
		}


		/// <summary>
		/// A mez� nyersanyaga. Csak getter.
		/// </summary>
		public Material Material
		{
			//read property
			get;
			//write property
			set;
		}

		/// <summary>
		/// H�nyas dob�sra termel nyersanyagot. Csak getter.
		/// A v�z produce numbere 0!
		/// </summary>
		public int ProduceNumber
		{
			//read property
			get;
			//write property
			set;
		}

		public virtual void Dispose()
		{

		}

		/// <summary>
		/// Ha van �t, a gazd�ja van benne, egy�bk�nt null.
		/// 6 elem� t�mb. Els� elem 1 �r�n�l, a t�bbi az �ramutat� j�r�s�nak megfelel�en.
		/// </summary>
		public Player[] Roads { get; set; }
		/// <summary>
		/// Telep�l�sek a cs�csokon. Ahol nincs ott null.
		/// 6 elem� t�mb, els� eleme a 12 �r�n�l tal�lhat� telep�l�s, a t�bbi az �ramutat�
		/// j�r�s�nak megfelel�en.
		/// </summary>
		private Settlement[] Settlements;
		
		public Settlement m_Settlement;

		public Hexagon()
			: this(null)
		{

		}

		public Hexagon(IEnumerable<Hexagon> neighbours)
		{
			if (neighbours == null)
				Neighbours = new List<Hexagon>();
			else
				Neighbours = new List<Hexagon>(neighbours);
			Settlements = new Settlement[6];
			Roads = new Player[6];
		}

        public Hexid Id
        {
            get;
            set;
        }

	   

		/// <summary>
		/// Konstruktor, inicializ�lja a hexagont.
		/// </summary>
		/// <param name="produceNumber">Mely dob�sra termel</param>
		/// <param name="material">A mez� nyersanyaga</param>
		public Hexagon(int produceNumber, Material material, Hexid id)
			: this(null)
		{
			Material = material;
			ProduceNumber = produceNumber;
			Id = id;
		}

		/// <summary>
		/// Lek�ri az adott poz�ci�n tal�lhat� utat.
		/// </summary>
		/// <param name="Position"></param>
		public Player GetRoad(int Position)
		{
			if (Position >= 0 && Position <= 5)
			{
				return Roads[Position];
			}
			return null;
		}

		/// <summary>
		/// Lek�ri az adott poz�ci�n tal�lhat� telep�l�st.
		/// </summary>
		/// <param name="Position"></param>
		public Settlement GetSettlement(int Position)
		{
			if (Position >= 0 && Position <= 5)
			{
				return Settlements[Position];
			}
			return null;
		}

		/// 
		/// <param name="Player">Tulajdonos</param>
		/// <param name="Position">hely</param>
		public void SetRoad(Player Player, int Position)
		{

		}

		/// <summary>
		/// Be�ll�tja az adott sarokra a megadott telep�l�st.
		/// </summary>
		/// <param name="Settlement"></param>
		/// <param name="Position"></param>
		public void SetTown(Settlement Settlement, int Position)
		{

		}

	}
}