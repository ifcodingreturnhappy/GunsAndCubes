using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField]
    public List<GameBehaviour> gameBehaviours;

    void Start()
    {
        foreach (var behaviour in gameBehaviours)
        {
            behaviour.Initialize();
        }
    }


    void Update()
    {
        foreach (var behaviour in gameBehaviours)
        {
            behaviour.Execute();
        }
    }
}
