﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BedBihan
{
    public interface IBoard
    {
        Hexagon grid
        {
            get;
            set;
        }
             
        void buildBoard();
    }
}
