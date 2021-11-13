using UnityEngine;

//todo возможно стоит использовать паттерн прокси и разделить потенциально толстую модель
public class ShipModel : IShipModel
{
    public float GetHealth { get; private set; }
    public float GetMaxHealth { get; private set; }
    
    public float GetSpeed { get; private set; }
    public float GetRotationSpeed { get; private set; }
    
    public Vector3 Position { get; private set; }
    public Vector3 Direction { get; private set; }
    public Quaternion Rotataion { get; private set; }

    public ShipModel(float getHealth, float getMaxHealth, float getSpeed, float getRotationSpeed, Vector3 position, Vector3 direction, Quaternion rotataion)
    {
        GetHealth = getHealth;
        GetMaxHealth = getMaxHealth;
        GetSpeed = getSpeed;
        GetRotationSpeed = getRotationSpeed;
        Position = position;
        Direction = direction;
        Rotataion = rotataion;
    }

    /// <summary>
    /// сюда можно передать отрицательное и положительное значения, в одном случае это будет хил, во втором дамаг
    /// </summary>
    /// <param name="amount"></param>
    public void AddHealth(float amount)
    {
        GetHealth += amount;
    }

    /// <summary>
    /// используем когда нам надо сбросить состояние до какого то значения, например когда откидываем игрока на респ, восстанавливаем фул хп
    /// </summary>
    /// <param name="amount"></param>
    public void SetHealth(float amount)
    {
        GetHealth = amount;
    }

    public void SetPosition(Vector3 position)
    {
        Position = position;
    }

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    public void SetRotation(Quaternion rotation)
    {
        Rotataion = rotation;
    }
}