using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OO
{
    public class Cell
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public char Value { get; private set; }

        public Cell(char _Value, int _Row, int _Column)
        {
            Value = _Value;
            Row = _Row;
            Column = _Column;
        }

        public override bool Equals(object obj)
        {
            var rightSide = obj as Cell;
            return Value == rightSide.Value &&
                Row == rightSide.Row &&
                Column == rightSide.Column;
        }
    }
}
