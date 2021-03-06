﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    class Position
    {
        public int x;
        public int y;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Adds the x and y coordinates of the position parameter to this Position.
        /// </summary>
        /// <param name="position"></param>
        /// <returns>Position containing the x and y values calculated from the sum of the positions</returns>
        public Position Add(Position position)
        {
            return new Position(this.x + position.x, this.y + position.y);
        }

        /// <summary>
        /// Checks if the Position parameter contains equivalent variables to this Position.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Equals(Position position)
        {
            if (this.x == position.x &&
                this.y == position.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
