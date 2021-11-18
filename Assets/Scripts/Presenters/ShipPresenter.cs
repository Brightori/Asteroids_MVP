using System;
using System.Collections.Generic;
using UnityEngine;

public class ShipPresenter : IShipPresenter, IDisposable 
{
    private IShipModel shipModel;
    private IView shipView;
    private IMoveSystem moveSystem;
    private IAbilitiesSystem abilitiesSystem;
    private IHealthSystem healthSystem;

    public ShipPresenter(IShipModel shipModel, IView shipView, IMoveSystem moveSystem)
    {
        this.shipModel = shipModel;
        this.shipView = shipView;
        this.moveSystem = moveSystem;

        shipView.OnCollisionEnterEvent += CollisionReact;
    }

    private void CollisionReact(Collision obj)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        shipView.OnCollisionEnterEvent -= CollisionReact;
    }
}