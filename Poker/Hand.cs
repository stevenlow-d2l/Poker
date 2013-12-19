using System.Collections.Generic;
using System.Linq;

namespace Poker {

	/// <summary>
	/// Represents the cards in a poker hand
	/// </summary>
	internal sealed class Hand{

		private readonly Card[] m_cards;

		public Hand(
				IEnumerable<Card> cards
			){

			m_cards = cards.OrderBy( c => c.Value ).ToArray();
		}

		/// <summary>
		/// The cards in the hand, ordered lowest to highest
		/// </summary>
		public Card[] Cards{
			get { return m_cards; }
		} 

		/// <summary>
		/// Evaluates the result of the hand
		/// </summary>
		/// <returns>The result of the hand</returns>
		public HandResult GetHandResult(){
			Dictionary<int, short> kindCounts = new Dictionary<int, short>();
			Card[] cards = m_cards.OrderBy( c => c.Value ).ToArray();

			bool isStraight = ( cards[4].Value - cards[0].Value ) == 4;
			bool isFlush = true;
			bool isRoyalFlush = true;

			Suit flushSuit = cards[0].Suit;
			for( int i=0; i< cards.Length; i++ ) {

				Card card = cards[i];

				if( isFlush ) {
					if( isRoyalFlush ) {
						if( i == 0 ) {
							isRoyalFlush = card.Value == 1;
						}else {
							isRoyalFlush = card.Value == i + 9;
						}
					}

					isFlush = card.Suit == flushSuit;
				}

				if( kindCounts.ContainsKey( card.Value ) ) {
					kindCounts[card.Value] += 1;
				}else {
					kindCounts.Add( card.Value, 1 );
				}
			}

			if( isRoyalFlush ) {
				return new HandResult( HandType.RoyalFlush, kindCounts );
			}

			HandType handType = HandType.HighCard;

			if( isFlush ) {
				if( isStraight ) {
					handType = HandType.StraightFlush;
				} else {
					handType = HandType.Flush;
				}
			} else if( isStraight ) {
				handType = HandType.Straight;
			}

			foreach( KeyValuePair<int, short> kindCount in kindCounts ) {

				if( kindCount.Value == 4 ) {
					handType = HandType.FourOfAKind;
					break;
				}

				if( kindCount.Value == 3 ) {
					if( handType == HandType.OnePair ) {
						handType = HandType.FullHouse;
						break;
					}
					handType = HandType.ThreeOfAKind;
				}

				if( kindCount.Value == 2 ) {
					if( handType == HandType.ThreeOfAKind ) {
						handType = HandType.FullHouse;
						break;
					}

					if( handType == HandType.OnePair ) {
						handType = HandType.TwoPair;
						break;
					}
					handType = HandType.OnePair;
				}
			}

			return new HandResult( handType, kindCounts );
		}

	}
}
