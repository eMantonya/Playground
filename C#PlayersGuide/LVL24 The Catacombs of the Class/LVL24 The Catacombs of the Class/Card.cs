using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LVL24_The_Catacombs_of_the_Class
{
    internal class Card
    {
        public CardRank _Rank { get; }
        public CardColor _Color { get; }

        public Card(CardRank rank, CardColor color)
        {
            _Rank = rank;
            _Color = color;
        }
        public bool IsSymbol => _Rank == CardRank.Ampersand || _Rank == CardRank.Caret || _Rank == CardRank.Percent || _Rank == CardRank.DollarSign;
        public bool IsNumber => !IsSymbol;
    }

    public enum CardColor { Red = 1, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }

}
