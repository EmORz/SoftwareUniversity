﻿using _08MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08MilitaryElite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
