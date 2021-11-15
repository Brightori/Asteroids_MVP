using UnityEngine;

//todo �������� ����� ������������ ������� ������ � ��������� ������������ ������� ������
public class ShipModel : IShipModel
{
    public float Health { get; private set; }
    public float MaxHealth { get; private set; }
    
    public float Speed { get; private set; }
    public float RotationSpeed { get; private set; }
    
    public Vector3 Position { get; private set; }
    public Vector3 Direction { get; private set; }
    public Quaternion Rotataion { get; private set; }
    public int Id { get; private set; }

    public ShipModel(int id, HealthData healthData, MoveData moveData, RotationData rotationData)
    {
        Id = id;
        Health = healthData.Health;
        MaxHealth = healthData.MaxHealth;
        
        Speed = moveData.Speed;
        Position = moveData.Position;

        RotationSpeed = rotationData.RotationSpeed;
        Rotataion = Quaternion.Euler(rotationData.Rotation);
    }

    /// <summary>
    /// ���� ����� �������� ������������� � ������������� ��������, � ����� ������ ��� ����� ���, �� ������ �����
    /// </summary>
    /// <param name="amount"></param>
    public void AddHealth(float amount)
    {
        Health += amount;
    }

    /// <summary>
    /// ���������� ����� ��� ���� �������� ��������� �� ������ �� ��������, �������� ����� ���������� ������ �� ����, ��������������� ��� ��
    /// </summary>
    /// <param name="amount"></param>
    public void SetHealth(float amount)
    {
        Health = amount;
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