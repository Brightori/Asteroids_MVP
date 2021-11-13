public interface IAbility 
{
    //todo пока передаем модель, возможно нужен отдельный тип данных обобщенный интерфейсом IAbilityContext
    void Execute(IModel owner, IModel target, bool enable = true);
    IAbilityData GetAbilityData { get; }
}

//todo это интерфейс под данные абилки которые должны торчать наружу (например рейнж или дмж для отрисовки)
public interface IAbilityData
{

}