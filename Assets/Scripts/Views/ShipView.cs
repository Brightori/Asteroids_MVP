using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ShipView : MonoBehaviour, IView
{
    public event Action<Collider> OnTriggerEnterEvent;
    public event Action<Collision> OnCollisionEnterEvent;
    public AssetReference assetReference;

    public void SetPosition(Vector3 position)
    {
        transform.position = position;

        var save = assetReference.AssetGUID;
        assetReference = new AssetReference(save);
    }

    public void SetRotation(Quaternion rotation)
    {
        transform.rotation = rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent?.Invoke(other);
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnCollisionEnterEvent?.Invoke(collision);
    }
}