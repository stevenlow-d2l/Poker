
namespace Poker {

	/// <summary>
	/// A Card from a deck
	/// </summary>
	internal sealed class Card {

		private readonly Suit m_suit;
		private readonly int m_value;

		public Card(
				Suit suit,
				int value
			){

			m_value = value;
			m_suit = suit;
		}

		/// <summary>
		/// The suit of the card
		/// </summary>
		public Suit Suit{
			get { return m_suit; }
		}

		/// <summary>
		/// The value of the card
		/// </summary>
		public int Value{
			get { return m_value; }
		}

	}
}
