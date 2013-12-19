using System.Linq;

namespace Poker {

	/// <summary>
	/// Evaluates and compares 2 poker hands
	/// </summary>
	internal sealed class HandComparer {

		/// <summary>
		/// Compares two poker hands and returns the winner, or null in the case of a draw
		/// </summary>
		/// <param name="hand1">The first hand</param>
		/// <param name="hand2">The second hand</param>
		/// <returns>The winning hand, or null in the case of a draw</returns>
		public Hand Compare( Hand hand1, Hand hand2 ) {

			HandResult hand1Result = hand1.GetHandResult();
			HandResult hand2Result = hand2.GetHandResult();
			int comparisonVal = hand1Result.HandType.CompareTo( hand2Result.HandType );

			if( comparisonVal > 0 ) {
				return hand1;
			}

			if( comparisonVal < 0 ) {
				return hand2;
			}

			//Tie Breaker
			switch( hand1Result.HandType ) {
				case HandType.Straight:
				case HandType.StraightFlush:

					int h1Max = hand1.Cards.Select( c => c.Value ).Max();
					int h2Max = hand2.Cards.Select( c => c.Value ).Max();
					if( h1Max > h2Max ) {
						return hand1;
					}

					if( h2Max > h1Max ) {
						return hand2;
					}
					break;

				case HandType.Flush:

					for( int i = 0; i < hand1.Cards.Length; i++ ) {
						int h1Val = hand1.Cards[i].Value;
						int h2Val = hand2.Cards[i].Value;
						if( h1Val > h2Val ) {
							return hand1;
						}

						if( h2Val > h1Val ) {
							return hand2;
						}
					}

					break;

				default:

					var hand1Ranked = hand1Result.TypeCounts
						.OrderByDescending( c => c.Value )
						.ThenByDescending( c => c.Key )
						.ToArray();

					var hand2Ranked = hand2Result.TypeCounts
						.OrderByDescending( c => c.Value )
						.ThenByDescending( c => c.Key )
						.ToArray();

					for( int i = 0; i < hand1Ranked.Length; i++ ) {
						int h1Val = hand1Ranked[i].Key;
						int h2Val = hand2Ranked[i].Key;

						if( h1Val > h2Val ) {
							return hand1;
						}

						if( h2Val > h1Val ) {
							return hand2;
						}
					}

					break;
			}

			return null;
		}

	}
}
