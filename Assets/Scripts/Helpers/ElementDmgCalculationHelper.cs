public class ElementDmgCalculationHelper
{
    public float ElementDmgCalculation(IDamage damage)
    {
        return 100;
    }

    private float FireToWaterDmg(float amount)
    {
        return amount * 0.5f;
    }
}