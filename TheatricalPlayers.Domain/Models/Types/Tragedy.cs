﻿using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayers.Domain.Models.Types;

public class Tragedy : IType
{
    public double Value { get; set; }

    const int maxAudience = 30;
    const double additionalValue = 10.00;

    public void CalculateValue(int audience, double baseValue)
    {
        Value = audience <= maxAudience ? baseValue : baseValue + (audience- maxAudience) * additionalValue;
    }
}
