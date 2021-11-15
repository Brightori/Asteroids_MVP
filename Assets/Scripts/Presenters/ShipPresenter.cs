public class ShipPresenter : IShipPresenter
{
    private IShipModel shipModel;
    private IView shipView;
    private IMoveSystem moveSystem;
    private IAbilitiesSystem abilitiesSystem;
    private IHealthSystem healthSystem;
}