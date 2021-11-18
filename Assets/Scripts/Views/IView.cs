using System;
using UnityEngine;

public interface IView
{
    void SetPosition(Vector3 position);
    void SetRotation(Quaternion rotation);

    event Action<Collider> OnTriggerEnterEvent;
    event Action<Collision> OnCollisionEnterEvent;
}
