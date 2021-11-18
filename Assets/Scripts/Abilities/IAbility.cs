public partial interface IAbility 
{
    void Execute(IAbilityContext owner, IAbilityContext target, bool enable = true);
    IAbilityData GetAbilityData { get; }
}

