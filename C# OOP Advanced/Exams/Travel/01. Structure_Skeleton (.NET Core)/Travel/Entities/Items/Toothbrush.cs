﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Travel.Entities.Items
{
    public class Toothbrush : Item
    {
        private const int Cost = 3;

        public Toothbrush() 
            : base(Cost)
        {
        }
    }
}
