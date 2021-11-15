using UnityEngine.AddressableAssets;

public interface IShipDescription : IDescription
{
    AssetReference ShipViewReference { get; }
    IShipModel GetShipModel { get; }
    bool IsPhysicsMoveMode { get; }
}
