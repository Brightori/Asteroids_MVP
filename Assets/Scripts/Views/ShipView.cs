using UnityEngine;

public class ShipView : MonoBehaviour, IView
{
    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }

    public void SetRotation(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
}