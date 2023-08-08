using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coIT.BewirbDich.Winforms.Domain;

/// <summary>
/// Represents the input parameters for the calculation.
/// - salesVolume: Annual turnover in euros.
/// - householdBudget: Household budget in euros.
/// - employeeCount: Total number of employees.
/// </summary>
public class CalculationBase
{
    public decimal baseVolume { get; set; }

    public void setBaseVolume(decimal volume, CalculationType type)
    {
        switch (type)
        {
            case CalculationType.salesVolume:
            case CalculationType.housholdBudget:
                baseVolume = volume;
                break;
            default:
                baseVolume = (int)volume;
                break;

        }
    }
}