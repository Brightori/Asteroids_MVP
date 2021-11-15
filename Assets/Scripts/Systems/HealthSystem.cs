public class HealthSystem : IHealthSystem
{
    private IHealth health;
    private ElementDmgCalculationHelper calculationHelper = new ElementDmgCalculationHelper();

    public void TakeDamage(IDamage damage)
    {
        
    }

    public void TakeDamage<T>(T damage) where T : IDamage
    {
        var finalDmgAmount = calculationHelper.ElementDmgCalculation(damage);
        health.AddHealth(-finalDmgAmount);
    }
}

public interface IHealthSystem
{
    void TakeDamage<T>(T damage) where T: IDamage;
}