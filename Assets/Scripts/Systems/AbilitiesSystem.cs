using System.Collections.Generic;

public class AbilitiesSystem
{
    private Dictionary<int, IAbility> abilities = new Dictionary<int, IAbility>();
}

public interface IAbilitiesSystem
{
    void ExecuteAbility(int index, bool enable = true);
    void AddAbility(IAbility ability);
    void RemoveAbility(IAbility ability);
}