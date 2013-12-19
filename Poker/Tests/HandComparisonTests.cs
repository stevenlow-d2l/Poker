using System.Collections.Generic;
using NUnit.Framework;

namespace Poker.Tests {

	[TestFixture]
	internal sealed class HandComparisonTests {

		[Test,TestCaseSource( "TestSources")]
		public void CompareHands( Hand loser, Hand winner ){
			HandComparer comparer = new HandComparer();
			Hand winningHand = comparer.Compare( loser, winner );
			Assert.AreEqual( winner, winningHand );
		}

		[Test, TestCaseSource( "TIE_BREAK_TEST_CASES" )]
		public void CompareTieBreaks( Hand hand1, Hand hand2, Hand expectedWinner ){
			
			HandComparer comparer = new HandComparer();
			Hand winningHand = comparer.Compare( hand1, hand2 );
			Assert.AreEqual( expectedWinner, winningHand );
		}

		private static IEnumerable<TestCaseData> TestSources{
			get{
				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.FLUSH_HIGH} )
					.SetName( "Compare_HighCardvsFlush_FlushWins");

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_HighCardvsFourOfAKind_FourOfAKindWins" );
				
				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.FULL_HOUSE_2_AND_3} )
					.SetName( "Compare_HighCardvsFullHouse_FullHouseWins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.ONE_PAIR_11} )
					.SetName( "Compare_HighCardvsOnePair_OnePairWins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.STRAIGHT_9} )
					.SetName( "Compare_HighCardvsStraight_StraightWins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_HighCardvsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.THREE_OF_A_KIND_2} )
					.SetName( "Compare_HighCardvsThreeOfAKind_ThreeOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.TWO_PAIR_EIGHT_OVER_SEVEN} )
					.SetName( "Compare_HighCardvsTwoPair_TwoPairWins" );

				yield return new TestCaseData( new[] { Hands.HIGH_CARD_EIGHT_FIVE, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_HighCardvsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.TWO_PAIR_EIGHT_OVER_SEVEN} )
					.SetName( "Compare_OnePairvsTwoPair_TwoPairWins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.THREE_OF_A_KIND_2} )
					.SetName( "Compare_OnePairvsThreeOfAKind_ThreeOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.FLUSH_HIGH} )
					.SetName( "Compare_OnePairvsFlush_FlushWins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.FULL_HOUSE_2_AND_3} )
					.SetName( "Compare_OnePairvsFullHouse_FullHouseWins" );
					
				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.STRAIGHT_9} )
					.SetName( "Compare_OnePairvsStraight_StraightWins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_OnePairvsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_OnePairvsFourOfAKind_FourOfAKindWins" );

				yield return new TestCaseData( new[] { Hands.ONE_PAIR_11, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_OnePairvsRoyalFlush_RoyalFlushWins" );
				
				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.FLUSH_HIGH} )
					.SetName( "Compare_TwoPairvsFlush_FlushWins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_TwoPairvsFourOfAKind_FourOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.FULL_HOUSE_2_AND_3} )
					.SetName( "Compare_TwoPairvsFullHouse_FullHouseWins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.STRAIGHT_9} )
					.SetName( "Compare_TwoPairvsStraight_StraightWins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_TwoPairvsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.THREE_OF_A_KIND_2} )
					.SetName( "Compare_TwoPairvsThreeOfAKind_ThreeOfAKindWins" );

				yield return new TestCaseData( new[] { Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_TwoPairvsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.FLUSH_HIGH} )
					.SetName( "Compare_ThreeOfAKindvsFlush_FlushWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_ThreeOfAKindvsFourOfAKind_FourOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.FULL_HOUSE_2_AND_3} )
					.SetName( "Compare_ThreeOfAKindvsFullHouse_FullHouseWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.STRAIGHT_9} )
					.SetName( "Compare_ThreeOfAKindvsStraight_StriaghtWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_ThreeOfAKindvsStraightFlush_StriaghtFlushWins" );

				yield return new TestCaseData( new[] { Hands.THREE_OF_A_KIND_2, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_ThreeOfAKindvsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_9, Hands.FLUSH_HIGH} )
					.SetName( "Compare_StraightvsFlush_FlushWins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_9, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_StraightvsFourOfAKind_FourOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_9, Hands.FULL_HOUSE_2_AND_3} )
					.SetName( "Compare_StraightvsFullHouse_FullHouseWins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_9, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_StraightvsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[] { Hands.STRAIGHT_9, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_StraightvsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[]{Hands.FLUSH_HIGH, Hands.FULL_HOUSE_2_AND_3} )
					.SetName( "Compare_FlushvsFullHouse_FullHouseWins" );

				yield return new TestCaseData( new[]{Hands.FLUSH_HIGH, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_FlushvsFourOfAKind_FourOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.FLUSH_HIGH, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_FlushvsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[] { Hands.FLUSH_HIGH, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_FlushvsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[]{Hands.FULL_HOUSE_2_AND_3, Hands.FOUR_OF_A_KIND_7} )
					.SetName( "Compare_FullHousevsFourOfAKind_FourOfAKindWins" );

				yield return new TestCaseData( new[]{Hands.FULL_HOUSE_2_AND_3, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_FullHousevsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[] { Hands.FULL_HOUSE_2_AND_3, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_FullHousevsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[]{Hands.FOUR_OF_A_KIND_7, Hands.STRAIGHT_FLUSH_5} )
					.SetName( "Compare_FourOfAKindvsStraightFlush_StraightFlushWins" );

				yield return new TestCaseData( new[] { Hands.STRAIGHT_FLUSH_5, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_StraightFlushvsRoyalFlush_RoyalFlushWins" );

				yield return new TestCaseData( new[] { Hands.FOUR_OF_A_KIND_7, Hands.ROYAL_FLUSH } )
					.SetName( "Compare_FourOfAKindvsRoyalFlush_RoyalFlushWins" );
			}
		}

		private static IEnumerable<TestCaseData> TIE_BREAK_TEST_CASES {
			get{
				yield return new TestCaseData( new[]{Hands.STRAIGHT_5, Hands.STRAIGHT_9, Hands.STRAIGHT_9} )
					.SetName( "Compare_Straight5vsStraight9_Straight9Wins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_9, Hands.STRAIGHT_5, Hands.STRAIGHT_9} )
					.SetName( "Compare_Straight9vsStraight5_Straight9Wins" );

				yield return new TestCaseData( new[]{Hands.FLUSH_LOW, Hands.FLUSH_HIGH, Hands.FLUSH_HIGH} )
					.SetName( "Compare_FlushLowvsFlushHigh_FlushHighWins" );

				yield return new TestCaseData( new[]{Hands.FLUSH_HIGH, Hands.FLUSH_LOW, Hands.FLUSH_HIGH} )
					.SetName( "Compare_FlushHighvsFlushLow_FlushHighWins" );

				yield return new TestCaseData( new[]{Hands.FOUR_OF_A_KIND_7, Hands.FOUR_OF_A_KIND_8, Hands.FOUR_OF_A_KIND_8} )
					.SetName( "Compare_Four7vsFour8_Four8Wins" );

				yield return new TestCaseData( new[]{Hands.FOUR_OF_A_KIND_8, Hands.FOUR_OF_A_KIND_7, Hands.FOUR_OF_A_KIND_8} )
					.SetName( "Compare_Four8vsFour7_Four8Wins" );

				yield return new TestCaseData( new[]{Hands.FOUR_OF_A_KIND_8, Hands.FOUR_OF_A_KIND_8_HIGH_KICKER, Hands.FOUR_OF_A_KIND_8_HIGH_KICKER} )
					.SetName( "Compare_Four8vsFour8HighKicker_Four8HighKickerWins" );

				yield return new TestCaseData( new[]{Hands.FOUR_OF_A_KIND_8_HIGH_KICKER, Hands.FOUR_OF_A_KIND_8, Hands.FOUR_OF_A_KIND_8_HIGH_KICKER} )
					.SetName( "Compare_Four8HighKickervsFour8_Four8HighKickerWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_6, Hands.THREE_OF_A_KIND_2, Hands.THREE_OF_A_KIND_6} )
					.SetName( "Compare_Three6vsThree2_Three6Wins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.THREE_OF_A_KIND_6, Hands.THREE_OF_A_KIND_6} )
					.SetName( "Compare_Three2vsThree6_Three6Wins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2, Hands.THREE_OF_A_KIND_2_HIGH_KICKER, Hands.THREE_OF_A_KIND_2_HIGH_KICKER} )
					.SetName( "Compare_Three2vsThree2HighKicker_Three2HighKickerWins" );

				yield return new TestCaseData( new[]{Hands.THREE_OF_A_KIND_2_HIGH_KICKER, Hands.THREE_OF_A_KIND_2, Hands.THREE_OF_A_KIND_2_HIGH_KICKER} )
					.SetName( "Compare_Three2HighKickervsThree2_Three2HighKickerWins" );

				yield return new TestCaseData( new[]{Hands.FULL_HOUSE_2_AND_3, Hands.FULL_HOUSE_3_AND_2, Hands.FULL_HOUSE_3_AND_2} )
					.SetName( "Compare_FullHouse2And3vsFullHouse3And2_FullHouse3And2Wins" );

				yield return new TestCaseData( new[]{Hands.FULL_HOUSE_3_AND_2, Hands.FULL_HOUSE_2_AND_3, Hands.FULL_HOUSE_3_AND_2} )
					.SetName( "Compare_FullHouse3And2vsFullHouse2And3_FullHouse3And2Wins" );

				yield return new TestCaseData( new[]{Hands.FULL_HOUSE_3_AND_5, Hands.FULL_HOUSE_3_AND_2, Hands.FULL_HOUSE_3_AND_5} )
					.SetName( "Compare_FullHouse3And5vsFullHouse3And3_FullHouse3And5Wins");

				yield return new TestCaseData( new[]{Hands.FULL_HOUSE_3_AND_2, Hands.FULL_HOUSE_3_AND_5, Hands.FULL_HOUSE_3_AND_5} )
					.SetName( "Compare_FullHouse3And2vsFullHouse3And5_FullHouse3And5Wins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.ONE_PAIR_6, Hands.ONE_PAIR_11} )
					.SetName( "Compare_OnePair11vsOnePair6_OnePair11Wins" );

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_6, Hands.ONE_PAIR_11, Hands.ONE_PAIR_11} )
					.SetName("Compare_OnePair6vsOnePair11_OnePair11Wins");

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11, Hands.ONE_PAIR_11_HIGH_KICKER, Hands.ONE_PAIR_11_HIGH_KICKER} )
					.SetName("Compare_OnePair11vsOnePair11HighKicker_OnePair11HighKickerWins");

				yield return new TestCaseData( new[]{Hands.ONE_PAIR_11_HIGH_KICKER, Hands.ONE_PAIR_11, Hands.ONE_PAIR_11_HIGH_KICKER} )
					.SetName( "Compare_OnePair11HighKickervsOnePair11_OnePair11HighKickerWins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_FLUSH_5, Hands.STRAIGHT_FLUSH_9, Hands.STRAIGHT_FLUSH_9} )
					.SetName( "Compare_StraightFlush5vsStraightFlush9_StraightFlush9Wins" );

				yield return new TestCaseData( new[]{Hands.STRAIGHT_FLUSH_9, Hands.STRAIGHT_FLUSH_5, Hands.STRAIGHT_FLUSH_9} )
					.SetName( "Compare_StraightFlush9vsStraightFlush5_StraightFlush9Wins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_NINE_OVER_SEVEN, Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.TWO_PAIR_NINE_OVER_SEVEN} )
					.SetName("Compare_TwoPair9Over7vsTwoPair8Over7_TwoPair9Over7Wins");

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.TWO_PAIR_NINE_OVER_SEVEN, Hands.TWO_PAIR_NINE_OVER_SEVEN} )
					.SetName("Compare_TwoPair8Over7vsTwoPair9Over7_TwoPair9Over7Wins");

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_NINE_OVER_FIVE, Hands.TWO_PAIR_NINE_OVER_SEVEN, Hands.TWO_PAIR_NINE_OVER_SEVEN} )
					.SetName( "Compare_TwoPair9Over5vsTwoPair9Over7_TwoPair9Over7Wins" );

				yield return new TestCaseData( new[]{Hands.TWO_PAIR_NINE_OVER_SEVEN, Hands.TWO_PAIR_NINE_OVER_FIVE, Hands.TWO_PAIR_NINE_OVER_SEVEN} )
					.SetName( "Compare_TwoPair9Over7vsTwoPair9Over5_TwoPair9Over7Wins" );
				
				yield return new TestCaseData(  new[]{ Hands.TWO_PAIR_NINE_OVER_FIVE, Hands.TWO_PAIR_NINE_OVER_FIVE_HIGH_KICKER, Hands.TWO_PAIR_NINE_OVER_FIVE_HIGH_KICKER } )
					.SetName( "Compare_TwoPair9Over5vsTwoPair9Over5HighKicker_TwoPair9Over5HighKickerWins" );

				yield return new TestCaseData( new[]{ Hands.TWO_PAIR_NINE_OVER_FIVE_HIGH_KICKER, Hands.TWO_PAIR_NINE_OVER_FIVE, Hands.TWO_PAIR_NINE_OVER_FIVE_HIGH_KICKER } )
					.SetName("Compare_TwoPair9Over5HighKickervsTwoPair9Over5_TwoPair9Over5HighKickerWins");

				yield return new TestCaseData(  new[]{Hands.HIGH_CARD_EIGHT_FIVE, Hands.HIGH_CARD_SEVEN_SIX, Hands.HIGH_CARD_EIGHT_FIVE} )
					.SetName( "Compare_HighCard8vsHighCard7_HighCard8Wins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_SEVEN_SIX, Hands.HIGH_CARD_EIGHT_FIVE, Hands.HIGH_CARD_EIGHT_FIVE} )
					.SetName( "Compare_HighCard7vsHighCard8_HighCard8Wins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_SEVEN_FIVE, Hands.HIGH_CARD_SEVEN_SIX, Hands.HIGH_CARD_SEVEN_SIX} )
					.SetName( "Compare_HighCard7And5vsHighCard7And6_HighCard7And6Wins" );

				yield return new TestCaseData( new[]{Hands.HIGH_CARD_SEVEN_SIX, Hands.HIGH_CARD_SEVEN_FIVE, Hands.HIGH_CARD_SEVEN_SIX} )
					.SetName( "Compare_HighCard7And6vsHighCard7And5_HighCard7And6Wins" );


				yield return new TestCaseData( new[] { Hands.HIGH_CARD_SEVEN_SIX, Hands.HIGH_CARD_SEVEN_SIX, null } )
					.SetName( "Compare_HighCard_Draw" );

				yield return new TestCaseData( new[] { Hands.ONE_PAIR_11, Hands.ONE_PAIR_11, null } )
					.SetName( "Compare_OnePair_Draw" );

				yield return new TestCaseData( new[] { Hands.THREE_OF_A_KIND_2, Hands.THREE_OF_A_KIND_2, null } )
					.SetName( "Compare_ThreeOfAKind_Draw" );

				yield return new TestCaseData( new[] { Hands.TWO_PAIR_EIGHT_OVER_SEVEN, Hands.TWO_PAIR_EIGHT_OVER_SEVEN, null } )
					.SetName( "Compare_TwoPair_Draw" );

				yield return new TestCaseData( new[] { Hands.STRAIGHT_9, Hands.STRAIGHT_9, null } )
					.SetName( "Compare_Straight_Draw" );

				yield return new TestCaseData( new[] { Hands.FLUSH_HIGH, Hands.FLUSH_HIGH, null } )
					.SetName( "Compare_Flush_Draw" );

				yield return new TestCaseData( new[] { Hands.FULL_HOUSE_2_AND_3, Hands.FULL_HOUSE_2_AND_3, null } )
					.SetName( "Compare_FullHouse_Draw" );

				yield return new TestCaseData( new[] { Hands.FOUR_OF_A_KIND_7, Hands.FOUR_OF_A_KIND_7, null } )
					.SetName( "Compare_FourOfAKind_Draw" );

				yield return new TestCaseData( new[] { Hands.STRAIGHT_FLUSH_5, Hands.STRAIGHT_FLUSH_5, null } )
					.SetName( "Compare_StraightFlush_Draw" );

				yield return new TestCaseData( new[] { Hands.ROYAL_FLUSH, Hands.ROYAL_FLUSH, null } )
					.SetName( "Compare_RoyalFlush_Draw" );
			}
		}


	}
}
