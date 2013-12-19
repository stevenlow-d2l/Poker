using System.Collections.Generic;

namespace Poker {
	/// <summary>
	/// The result of a poker Hand
	/// </summary>
	internal sealed class HandResult {

		private readonly HandType m_handType;
		private readonly Dictionary<int, short> m_typeCounts;

		public HandResult(
				HandType handType,
				Dictionary<int,short> typeCounts
			){

			m_typeCounts = typeCounts;
			m_handType = handType;
		}

		/// <summary>
		/// The Type of the hand
		/// </summary>
		public HandType HandType{
			get { return m_handType; }
		}

		/// <summary>
		/// The counts of the card values
		/// </summary>
		public Dictionary<int, short> TypeCounts{
			get { return m_typeCounts; }
		}
	}
}
