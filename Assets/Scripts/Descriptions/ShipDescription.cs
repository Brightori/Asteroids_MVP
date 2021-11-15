using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
public class ShipDescription : IShipDescription
{
    [SerializeField] private HealthData healthData;
    [SerializeField] private MoveData moveData;
    [SerializeField] private RotationData rotationData;
    [SerializeField] private IdentifierContainer identifierContainer;
    [SerializeField] private AssetReference shipViewReference;

    public AssetReference ShipViewReference => shipViewReference;

    public IShipModel GetShipModel => new ShipModel(Id, healthData, moveData, rotationData);
    public bool IsPhysicsMoveMode { get; }
    public int Id => identifierContainer.Id;
}

[Serializable]
public struct HealthData
{
    public float Health;
    public float MaxHealth;
}

[Serializable]
public struct MoveData
{
    public Vector3 Position;
    public float Speed;
}

[Serializable]
public struct RotationData
{
    public Vector3 Rotation;
    public float RotationSpeed;
}