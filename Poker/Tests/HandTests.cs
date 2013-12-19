using System.Collections.Generic;
using NUnit.Framework;

namespace Poker.Tests {
	[TestFixture]
	internal sealed class HandTests{

		[TestCaseSource( "TestCases" ) ]
		public void RunTest( Hand hand, HandType expectedHandType ) {

			HandResult handResult = hand.GetHandResult();
			Assert.AreEqual( expectedHandType, handResult.HandType );
		}
		
		private static readonly object[] HIGHCARD_TEST_CASE = new object[]{
			Hands.HIGH_CARD_EIGHT_FIVE,
			HandType.HighCard
		};

		private static readonly object[] ONE_PAIR_TEST_CASE = new object[]{
			Hands.ONE_PAIR_11,
			HandType.OnePair
		};

		private static readonly object[] THREE_OF_A_KIND_TEST_CASE = new object[]{
			Hands.THREE_OF_A_KIND_2,
			HandType.ThreeOfAKind
		};

		private static readonly object[] TWO_PAIR_TEST_CASE = new object[]{
			Hands.TWO_PAIR_EIGHT_OVER_SEVEN,
			HandType.TwoPair
		};

		private static readonly object[] FOUR_OF_A_KIND = new object[]{
			Hands.FOUR_OF_A_KIND_7,
			HandType.FourOfAKind
		};

		private static readonly object[] STRAIGHT = new object[]{
			Hands.STRAIGHT_5,
			HandType.Straight
		};

		private static readonly object[] FLUSH = new object[]{
			Hands.FLUSH_HIGH,
			HandType.Flush
		};

		private static readonly object[] FULL_HOUSE_PAIR_LOWER = new object[]{
			Hands.FULL_HOUSE_3_AND_2,
			HandType.FullHouse
		};

		private static readonly object[] FULL_HOUSE_THREE_LOWER = new object[]{
			Hands.FULL_HOUSE_2_AND_3,
			HandType.FullHouse
		};

		private static readonly object[] STRAIGHT_FLUSH = new object[]{
			Hands.STRAIGHT_FLUSH_5,
			HandType.StraightFlush
		};

		private static readonly object[] ROYAL_FLUSH = new object[]{
			Hands.ROYAL_FLUSH,
			HandType.RoyalFlush
		};


		private static IEnumerable<TestCaseData> TestCases{
			get{
				yield return new TestCaseData( HIGHCARD_TEST_CASE )
					.SetName( "GetHandResult_HighCard_HighCardReturned" );

				yield return new TestCaseData( ONE_PAIR_TEST_CASE )
					.SetName( "GetHandResult_OnePair_OnePairReturned" );

				yield return new TestCaseData( THREE_OF_A_KIND_TEST_CASE )
					.SetName( "GetHandResult_ThreeOfAKind_ThreeOfAKindReturned" );

				yield return new TestCaseData( TWO_PAIR_TEST_CASE )
					.SetName( "GetHandResult_TwoPair_TwoPairReturned" );

				yield return new TestCaseData( FOUR_OF_A_KIND )
					.SetName( "GetHandResult_FourOfAKind_FourOfAKindReturned" );

				yield return new TestCaseData( STRAIGHT )
					.SetName( "GetHandResult_Straight_StraightReturned" );

				yield return new TestCaseData( FLUSH )
					.SetName( "GetHandResult_Flush_FlushReturned" );

				yield return new TestCaseData( STRAIGHT_FLUSH )
					.SetName( "GetHandResult_StraightFlush_StraightFlushReturned" );

				yield return new TestCaseData( FULL_HOUSE_PAIR_LOWER )
					.SetName( "GetHandResult_FullHousePairLower_FullHouseReturned" );

				yield return new TestCaseData( FULL_HOUSE_THREE_LOWER )
					.SetName( "GetHandResult_FullHouseThreeLower_FullHouseReturned" );

				yield return new TestCaseData( ROYAL_FLUSH )
					.SetName( "GetHandResult_RoyalFlush_RoyalFlushReturned" );
			}
		}

	}
}
