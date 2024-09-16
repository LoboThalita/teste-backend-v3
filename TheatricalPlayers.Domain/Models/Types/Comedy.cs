﻿using TheatricalPlayers.Domain.Interfaces;

namespace TheatricalPlayers.Domain.Models.Types;

public class Comedy : CreditType, IType
{
    public double Value { get; set;  }

    const int maxAudience = 20;
    const double additionalValue = 5.00;
    public double CalculateValue(int audience, double baseValue)
    {
        baseValue += 3.00 * audience;

        Value = audience > maxAudience ? baseValue +  100.00 + (audience - maxAudience) * additionalValue : baseValue;
        return Value;
    }
    public override int CalculateCreditType(int audience)
    {
        int baseCredit = base.CalculateCreditType(audience);

        int bonus = audience / 5;

        return baseCredit + bonus;
    }
}
