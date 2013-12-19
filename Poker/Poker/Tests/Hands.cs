
namespace Poker.Tests {

	internal static class Hands {
		public readonly static Hand STRAIGHT_9 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 6 ), 
				     new Card( Suit.Diamonds, 5 ), 
				     new Card( Suit.Spades, 9 ), 
				     new Card( Suit.Diamonds, 7 ),
				     new Card( Suit.Diamonds, 8 )
			     }
			);

		public readonly static Hand STRAIGHT_5 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 4 ), 
				     new Card( Suit.Diamonds, 3 ), 
				     new Card( Suit.Spades, 5 ), 
				     new Card( Suit.Diamonds, 1 ),
				     new Card( Suit.Diamonds, 2 )
			     }
			);

		public readonly static Hand FLUSH_HIGH = new Hand(
			new[]{
				     new Card( Suit.Hearts, 8 ),
				     new Card( Suit.Hearts, 7 ),
				     new Card( Suit.Hearts, 6 ),
				     new Card( Suit.Hearts, 4 ),
				     new Card( Suit.Hearts, 3 ), 
			     }
			);

		public readonly static Hand FLUSH_LOW = new Hand(
			new[]{
				     new Card( Suit.Hearts, 8 ),
				     new Card( Suit.Hearts, 7 ),
				     new Card( Suit.Hearts, 6 ),
				     new Card( Suit.Hearts, 2 ),
				     new Card( Suit.Hearts, 1 ), 
			     }
			);

		public readonly static Hand FOUR_OF_A_KIND_8 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 8), 
				     new Card( Suit.Hearts, 8),
				     new Card( Suit.Diamonds, 8),
				     new Card( Suit.Spades, 8 ),
				     new Card( Suit.Clubs, 1 ) 
			     } );

		public readonly static Hand FOUR_OF_A_KIND_8_HIGH_KICKER = new Hand(
			new[]{
				     new Card( Suit.Clubs, 8), 
				     new Card( Suit.Hearts, 8),
				     new Card( Suit.Diamonds, 8),
				     new Card( Suit.Spades, 8 ),
				     new Card( Suit.Clubs, 5 ) 
			     } );

		public readonly static Hand FOUR_OF_A_KIND_7 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 7), 
				     new Card( Suit.Hearts, 7),
				     new Card( Suit.Diamonds, 7),
				     new Card( Suit.Spades, 7 ),
				     new Card( Suit.Clubs, 2 ) 
			     } );

		public readonly static Hand THREE_OF_A_KIND_6 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 6), 
				     new Card( Suit.Hearts, 6),
				     new Card( Suit.Diamonds, 6),
				     new Card( Suit.Spades, 8 ),
				     new Card( Suit.Clubs, 5 ) 
			     } );

		public readonly static Hand THREE_OF_A_KIND_2 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 2), 
				     new Card( Suit.Hearts, 2),
				     new Card( Suit.Diamonds, 2),
				     new Card( Suit.Spades, 8 ),
				     new Card( Suit.Clubs, 5 ) 
			     } );

		public readonly static Hand THREE_OF_A_KIND_2_HIGH_KICKER = new Hand(
			new[]{
				     new Card( Suit.Clubs, 2), 
				     new Card( Suit.Hearts, 2),
				     new Card( Suit.Diamonds, 2),
				     new Card( Suit.Spades, 5 ),
				     new Card( Suit.Clubs, 9 ) 
			     } );

		public readonly static Hand FULL_HOUSE_3_AND_2 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 2), 
				     new Card( Suit.Hearts, 2),
				     new Card( Suit.Diamonds, 3),
				     new Card( Suit.Spades, 3 ),
				     new Card( Suit.Clubs, 3 ) 
			     }
			);

		public readonly static Hand FULL_HOUSE_2_AND_3 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 2), 
				     new Card( Suit.Hearts, 2),
				     new Card( Suit.Diamonds, 2),
				     new Card( Suit.Spades, 3 ),
				     new Card( Suit.Clubs, 3 ) 
			     }
			);

		public readonly static Hand FULL_HOUSE_3_AND_5 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 5), 
				     new Card( Suit.Hearts, 5),
				     new Card( Suit.Diamonds, 3),
				     new Card( Suit.Spades, 3 ),
				     new Card( Suit.Clubs, 3 ) 
			     }
			);

		public readonly static Hand ONE_PAIR_6 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 6), 
				     new Card( Suit.Hearts, 6),
				     new Card( Suit.Diamonds, 1),
				     new Card( Suit.Spades, 2 ),
				     new Card( Suit.Clubs, 3 ) 
			     }
			);

		public readonly static Hand ONE_PAIR_11 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 11), 
				     new Card( Suit.Hearts, 11),
				     new Card( Suit.Diamonds, 1),
				     new Card( Suit.Spades, 2 ),
				     new Card( Suit.Clubs, 3 ) 
			     }
			);

		public readonly static Hand ONE_PAIR_11_HIGH_KICKER = new Hand(
			new[]{
				     new Card( Suit.Clubs, 11), 
				     new Card( Suit.Hearts, 11),
				     new Card( Suit.Diamonds, 1),
				     new Card( Suit.Spades, 4 ),
				     new Card( Suit.Clubs, 3 ) 
			     }
			);

		public readonly static Hand STRAIGHT_FLUSH_9 = new Hand(
			new[]{
				     new Card( Suit.Clubs, 9), 
				     new Card( Suit.Clubs, 7),
				     new Card( Suit.Clubs, 8),
				     new Card( Suit.Clubs, 6 ),
				     new Card( Suit.Clubs, 5 ) 
			     }
			);

		public readonly static Hand STRAIGHT_FLUSH_5 = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 4), 
				     new Card( Suit.Diamonds, 5),
				     new Card( Suit.Diamonds, 1),
				     new Card( Suit.Diamonds, 2 ),
				     new Card( Suit.Diamonds, 3 ) 
			     }
			);

		public readonly static Hand TWO_PAIR_NINE_OVER_SEVEN = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 9), 
				     new Card( Suit.Clubs, 9),
				     new Card( Suit.Diamonds, 7),
				     new Card( Suit.Clubs, 7 ),
				     new Card( Suit.Diamonds, 3 ) 
			     }
			);

		public readonly static Hand TWO_PAIR_EIGHT_OVER_SEVEN = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 8), 
				     new Card( Suit.Clubs, 8),
				     new Card( Suit.Diamonds, 7),
				     new Card( Suit.Clubs, 7 ),
				     new Card( Suit.Diamonds, 3 ) 
			     }
			);

		public readonly static Hand TWO_PAIR_NINE_OVER_FIVE = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 9), 
				     new Card( Suit.Clubs, 9),
				     new Card( Suit.Diamonds, 5),
				     new Card( Suit.Clubs, 5 ),
				     new Card( Suit.Diamonds, 3 ) 
			     }
			);

		public readonly static Hand TWO_PAIR_NINE_OVER_FIVE_HIGH_KICKER = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 9), 
				     new Card( Suit.Clubs, 9),
				     new Card( Suit.Diamonds, 5),
				     new Card( Suit.Clubs, 5 ),
				     new Card( Suit.Diamonds, 4 ) 
			     }
			);

		public readonly static Hand HIGH_CARD_SEVEN_SIX = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 2), 
				     new Card( Suit.Clubs, 6),
				     new Card( Suit.Diamonds, 7),
				     new Card( Suit.Clubs, 5 ),
				     new Card( Suit.Diamonds, 4 ) 
			     }
			);

		public readonly static Hand HIGH_CARD_EIGHT_FIVE = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 8), 
				     new Card( Suit.Clubs, 1),
				     new Card( Suit.Diamonds, 2),
				     new Card( Suit.Clubs, 5 ),
				     new Card( Suit.Diamonds, 4 ) 
			     }
			);

		public readonly static Hand HIGH_CARD_SEVEN_FIVE = new Hand(
			new[]{
				     new Card( Suit.Diamonds, 7), 
				     new Card( Suit.Clubs, 1),
				     new Card( Suit.Diamonds, 2),
				     new Card( Suit.Clubs, 5 ),
				     new Card( Suit.Diamonds, 4 ) 
			     }
			);

		public readonly static Hand ROYAL_FLUSH = new Hand(
			new[]{
				     new Card( Suit.Hearts, 10 ),
 					 new Card( Suit.Hearts, 12 ),
 					 new Card( Suit.Hearts, 13 ),
					 new Card( Suit.Hearts, 1 ), 
 					 new Card( Suit.Hearts, 11 ) 
			     }
			);
	}
}
