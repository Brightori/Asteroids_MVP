public partial interface IAbility 
{
    //todo ���� �������� ������, �� ��� ����� ��������� ��� ������ ���������� ����������� IAbilityContext
    void Execute(IAbilityContext owner, IAbilityContext target, bool enable = true);
    IAbilityData GetAbilityData { get; }
}

