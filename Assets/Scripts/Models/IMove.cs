using UnityEngine;

public interface IMove 
{ 
    Vector3 Position { get; }
    Vector3 Direction {  get; }

    void SetPosition(Vector3 position);
    void SetDirection(Vector3 direction);
}
