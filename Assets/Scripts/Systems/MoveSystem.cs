using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : IStandartMoveSystem
{
    private IMove moveData;

    public void Pause()
    {
        throw new System.NotImplementedException();
    }

    public void Unpause()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateLocal(float deltaTime)
    {
        throw new System.NotImplementedException();
    }
}

public interface IStandartMoveSystem : IMoveSystem , IUpdatable
{  }

public interface IMoveSystem 
{
    void Pause();
    void Unpause();
}
