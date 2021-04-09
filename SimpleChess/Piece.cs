using System;

namespace SimpleChess
{
    abstract class Piece
    {
        public string Symbol { get; }

        protected Piece(string symbol)
        {
            Symbol = symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition);
    }
}

/*namespace simplechess
{
    class piece
    {
        public string symbol { get; }
        private readonly string _type;

        public piece(string type, string symbol)
        {
            _type = type;
            symbol = symbol;
        }

        public bool move(string fromposition, string toposition)
        {
            if (_type == "rook") return fromposition[0] == toposition[0] || fromposition[1] == toposition[1];
            if (_type == "bishop")
            {
                var diffcol = fromposition[0] - toposition[0];
                var diffrow = fromposition[1] - toposition[1];
                return math.abs(diffrow) == math.abs(diffcol);
            }
            return true;
        }
    }
}
