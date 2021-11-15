using UnityEngine;

[CreateAssetMenu]
public class IdentifierContainer : ScriptableObject, IIdentifier
{
    [SerializeField, HideInInspector] private int ID;
    
    public int Id
    {
        get
        {
            if (ID == 0)
                ID = Animator.StringToHash(name); //можно заменить на свой генератор инты из стринги

            return ID;
        }
    }
}