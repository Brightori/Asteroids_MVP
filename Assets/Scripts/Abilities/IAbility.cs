public interface IAbility 
{
    //todo ���� �������� ������, �������� ����� ��������� ��� ������ ���������� ����������� IAbilityContext
    void Execute(IModel owner, IModel target, bool enable = true);
    IAbilityData GetAbilityData { get; }
}

//todo ��� ��������� ��� ������ ������ ������� ������ ������� ������ (�������� ����� ��� ��� ��� ���������)
public interface IAbilityData
{

}