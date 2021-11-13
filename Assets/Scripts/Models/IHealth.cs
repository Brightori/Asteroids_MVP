public interface IHealth
{
    float GetHealth { get; }
    float GetMaxHealth { get; }

    void SetHealth(float amount);
    void AddHealth(float amount);
}
