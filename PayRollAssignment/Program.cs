// See https://aka.ms/new-console-template for more information
Console.WriteLine(new TayPymentCalculator().CalculateTaxPay(4000000m));
//Console.WriteLine(new TayPymentCalculator().CalculateTaxableIncome(50000m));
public class TayPymentCalculator
{
    public decimal CalculateTaxPay(decimal monthlySalary)
    {
        var taxableIncome = CalculateTaxableIncome(monthlySalary);
        if (taxableIncome == default) return default;

        decimal paye = default;
        if (taxableIncome <= 300000) paye = taxableIncome * (7 / (decimal)100);
        if (taxableIncome > 300000 && taxableIncome <= 600000)
        {
            paye = 300000 * (7 / (decimal)100);
            taxableIncome -= 300000;
            paye += taxableIncome * (11 / (decimal)100);
        }
        else if (taxableIncome > 600000 && taxableIncome <= 1100000)
        {
            paye = 300000 * (7 / (decimal)100);
            taxableIncome -= 300000;
            var res = 300000 * (11 / (decimal)100);
            taxableIncome -= 300000;
            paye += res;
            res = taxableIncome * (15 / (decimal)100);
            taxableIncome -= res;
            paye += res;
        }
        else if (taxableIncome > 1100000 && taxableIncome <= 1600000)
        {
            paye = 300000 * (7 / (decimal)100);
            taxableIncome -= 300000;
            var res = 300000 * (11 / (decimal)100);
            taxableIncome -= 300000;
            paye += res;
            res = 500000 * (15 / (decimal)100);
            taxableIncome -= 500000;
            paye += res;
            res = taxableIncome * (19 / (decimal)100);
            taxableIncome -= res;
            paye += res;
        }
        else if (taxableIncome > 1600000 && taxableIncome <= 3200000)
        {
            paye = 300000 * (7 / (decimal)100);
            taxableIncome -= 300000;
            var res = 300000 * (11 / (decimal)100);
            taxableIncome -= 300000;
            paye += res;
            res = 500000 * (15 / (decimal)100);
            taxableIncome -= 500000;
            paye += res;
            res = 500000 * (19 / (decimal)100);
            taxableIncome -= 500000;
            paye += res;
            res = taxableIncome * (21 / (decimal)100);
            taxableIncome -= res;
            paye += res;
        }
        else if (taxableIncome > 3200000)
        {
            paye = 300000 * (7 / (decimal)100);
            taxableIncome -= 300000;
            var res = 300000 * (11 / (decimal)100);
            taxableIncome -= 300000;
            paye += res;
            res = 500000 * (15 / (decimal)100);
            taxableIncome -= 500000;
            paye += res;
            res = 500000 * (19 / (decimal)100);
            taxableIncome -= 500000;
            paye += res;
            res = 1600000 * (21 / (decimal)100);
            taxableIncome -= 1600000;
            paye += res;
            res = taxableIncome * (24 / (decimal)100);
            taxableIncome -= res;
            paye += res;
        }
        return paye / 12;


    }
    public decimal CalculateTaxableIncome(decimal monthlySalary)
    {
        if (monthlySalary <= 30000) return default;
        var grossIncome = monthlySalary * 12;
        var pension = grossIncome * (8 / (decimal)100);
        var consolidatedReliefAllowance = grossIncome * (1 / (decimal)100) > 200000 ? grossIncome * (1 / (decimal)100) : 200000;
        var secondGrossIncome = grossIncome - pension;
        var secondSonsolidatedReliefAllowance = secondGrossIncome * (20 / (decimal)100);
        var taxableIncome = grossIncome - (pension + consolidatedReliefAllowance + secondSonsolidatedReliefAllowance);
        return taxableIncome;
    }

}
