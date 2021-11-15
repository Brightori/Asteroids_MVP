using UnityEngine;

public abstract class Description : ScriptableObject
{
    public abstract IDescription GetDescription { get; }
}
