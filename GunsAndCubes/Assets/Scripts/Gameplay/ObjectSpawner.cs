using Assets.Scripts.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : GameBehaviour
{
    [SerializeField] 
    private ObjectPooler objectPooler;
    private ObjectPool objectPool;

    [SerializeField]
    private string poolToSpawnFrom;

    public override void Initialize()
    {
        objectPool = objectPooler.GetPool(poolToSpawnFrom);
    }

    public override void Execute()
    {

    }
}
