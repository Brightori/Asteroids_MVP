using UnityEngine;

public interface IRotate
{
    Quaternion Rotataion { get; }
    void SetRotation(Quaternion rotation);
    float RotationSpeed { get; }
}
