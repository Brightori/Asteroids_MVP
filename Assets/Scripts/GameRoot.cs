using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    Dictionary<int, ShipDescription> shipDescriptions = new Dictionary<int, ShipDescription>();

    [SerializeField] private ShipDescriptionContainer shipDescription;

    [SerializeField] private Library library = new Library();
    [SerializeField] private IdentifierContainer identifierContainer;


    private void Start()
    {
        library.GetShipDescription(identifierContainer.Id);
    }

    public void Test()
    {
        library.LoadAllAssets();
    }
}

public static class IdentifierMap
{
    public static int PlayerShip { get; } = Animator.StringToHash("PlayerShip");
    public static int Health { get; } = Animator.StringToHash("Health");
}

public struct IDStorage
{
    public int ID;
    public static explicit operator int(IDStorage d) => d.ID;
}

public interface IFxAction
{
    void Action();
}

public interface AbilityAction
{
    void Action();
}
