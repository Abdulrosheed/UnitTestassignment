
namespace PayRollAssignment.UnitTest;

public class UnitTest
{
    [Fact]
    public void CalculateTaxableIncome_WhenCalledWithValueLessThanOrEqualToThirtyThousand_ShouldReturnDefaultValueForDecimal()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxableIncome(30000m);

        Assert.Equal(result , GetDefaultValue(result));
        
    }

    [Fact]
    public void CalculateTaxableIncome_WhenCalledWithValueLessGreaterThanThirtyThousand_ShouldReturnValueForTaxableIncome()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxableIncome(50000m);

        Assert.Equal(result , 241600.000m);
        
    }
    [Fact]
    public void CalculateTaxPay_WhenCalledWithValueLessThanOrEqualToThirtyThousand_ShouldReturnDefaultValueForDecimal()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxPay(20000m);

        Assert.Equal(result , GetDefaultValue(result));
        
    }
    [Fact]
    public void CalculateTaxPay_WhenCalledWithValueGreaterThanThirtyThousandButLessThanOrEqualToSixHundredThousand_ShouldReturnCorrectValue()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxPay(40000m);

        Assert.Equal(result , 894.1333333333333333333333333m);
        
    }
    [Fact]
     public void CalculateTaxPay_WhenCalledWithValueGreaterThanSixHundredThousandButLessThanOrEqualToOnePointOneMillion_ShouldReturnCorrectValue()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxPay(100000m);

        Assert.Equal(result , 5540.00000m);
        
    }
    [Fact]
    public void CalculateTaxPay_WhenCalledWithValueGreaterThanOnePointOneMillionButLessThanOrEqualToOnePointSixMillion_ShouldReturnCorrectValue()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxPay(500000m);

        Assert.Equal(result , 66986.666666666666666666666667m);
        
    }
      [Fact]
    public void CalculateTaxPay_WhenCalledWithValueGreaterThanOnePointSixMillionButLessThanOrEqualToThreePointTwoMillion_ShouldReturnCorrectValue()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxPay(2000000m);

        Assert.Equal(result , 331146.66666666666666666666667m);
        
    }
     [Fact]
    public void CalculateTaxPay_WhenCalledWithValueGreaterThanThreePointTwoMillion_ShouldReturnCorrectValue()
    {
        var objectcreated = new TayPymentCalculator();

        var result = objectcreated.CalculateTaxPay(4000000m);

        Assert.Equal(result , 679626.66666666666666666666667m);
        
    }
    private T GetDefaultValue<T> (T obj)
    {
        return default;
    }
}