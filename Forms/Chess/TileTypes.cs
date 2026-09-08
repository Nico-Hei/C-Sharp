using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    internal class TileTypes
    {
        public enum Background
        {
            DarkTile = 0,
            LightTile = 1
        }

        public enum FigureStyle
        {
            black = 0,
            white = 1
        }

        public enum Figure
        {
            Bishop = 0,
            King = 1,
            Knight = 2,
            Pawn = 3,
            Queen = 4,
            Rook = 5
        }
    }
}
