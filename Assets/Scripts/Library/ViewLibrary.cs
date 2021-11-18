using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ViewLibrary
{
    public Dictionary<int, IView> idToViewCollection = new Dictionary<int, IView>();
}

[Serializable]
public class Library
{
    [SerializeField] private List<Description> Descriptions = new List<Description>();

    public Dictionary<int, ShipDescription> shipDescription = new Dictionary<int, ShipDescription>();

    public void Init()
    {

    }

    public void LoadAllAssets()
    {
        Descriptions = AssetDatabase.FindAssets("t:Description")
               .Select(AssetDatabase.GUIDToAssetPath)
               .Select(AssetDatabase.LoadAssetAtPath<Description>).ToList();
    }

    public IShipDescription GetShipDescription(int ID)
    {
        if (shipDescription.TryGetValue(ID, out ShipDescription needed))
        {
            return needed;
        }
        else
            throw new Exception("нет корабля в базе с индексом " + ID);
    }
}
