public interface IHealth
{
    float Health { get; }
    float MaxHealth { get; }

    void SetHealth(float amount);
    void AddHealth(float amount);
}
