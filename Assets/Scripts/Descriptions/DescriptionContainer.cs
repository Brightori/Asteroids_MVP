using UnityEngine;

public class DescriptionContainer<T> : Description where T : IDescription
{
    [SerializeField] private T description;

    public override IDescription GetDescription => description;
}
