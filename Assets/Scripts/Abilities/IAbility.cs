public partial interface IAbility 
{
    //todo пока передаем модель, но тут нужен отдельный тип данных обобщенный интерфейсом IAbilityContext
    void Execute(IAbilityContext owner, IAbilityContext target, bool enable = true);
    IAbilityData GetAbilityData { get; }
}

