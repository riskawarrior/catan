namespace Catan.Model
{

	/// <summary>
	/// A t�rk�p alkot�eleme.
	/// </summary>
	public class Hexagon
	{

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
		/// <summary>
		/// Ha van �t, a gazd�ja van benne, egy�bk�nt null.
		/// 6 elem� t�mb. Els� elem 1 �r�n�l, a t�bbi az �ramutat� j�r�s�nak megfelel�en.
		/// </summary>
		private Player Roads;
		/// <summary>
		/// Telep�l�sek a cs�csokon. Ahol nincs ott null.
		/// 6 elem� t�mb, els� eleme a 12 �r�n�l tal�lhat� telep�l�s, a t�bbi az �ramutat�
		/// j�r�s�nak megfelel�en.
		/// </summary>
		private Settlement[] Settlements;
		public Material m_Material;
		public Settlement m_Settlement;

		public Hexagon()
		{

		}

		public virtual void Dispose()
		{

		}

		/// <summary>
		/// Konstruktor, inicializ�lja a hexagont.
		/// </summary>
		/// <param name="ProduceNumber">Mely dob�sra termel</param>
		/// <param name="Material">A mez� nyersanyaga</param>
		public Hexagon(int ProduceNumber, Material Material)
		{

		}

		/// <summary>
		/// Lek�ri az adott poz�ci�n tal�lhat� utat.
		/// </summary>
		/// <param name="Position"></param>
		public Player GetRoad(int Position)
		{

			return null;
		}

		/// <summary>
		/// Lek�ri az adott poz�ci�n tal�lhat� telep�l�st.
		/// </summary>
		/// <param name="Position"></param>
		public Settlement GetSettlement(int Position)
		{

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