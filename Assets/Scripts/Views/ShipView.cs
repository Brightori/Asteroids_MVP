using System;
using UnityEngine;

public class ShipView : MonoBehaviour, IView
{
    public event Action<Collider> OnTriggerEnterEvent;
    public event Action<Collision> OnCollisionEnterEvent;

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
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