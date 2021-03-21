using Assets.Scripts.Gameplay;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectPooler : GameBehaviour
{
    [SerializeField]
    private List<PoolableObject> poolableObjects;

    [SerializeField]
    private List<ObjectPool> pools;

    public override void Initialize()
    {
        InitializePools();
    }


    private void InitializePools()
    {
        pools = new List<ObjectPool>();

        foreach (var poolableObject in poolableObjects)
        {
            // Create pool for the object
            ObjectPool pool = new ObjectPool();

            pool.poolName = poolableObject.PoolName;
            pool.poolSize = poolableObject.PoolSize;
            pool.pool = CreatePoolQueue(poolableObject);

            // Add pool to the list of pools
            pools.Add(pool);
        }
    }

    private Queue<GameObject> CreatePoolQueue(PoolableObject poolableObject)
    {
        Queue<GameObject> poolQueue = new Queue<GameObject>();

        // Create a parent for the pool object instances
        Transform poolParent = new GameObject().transform;
        poolParent.parent = this.transform;
        poolParent.name = poolableObject.PoolName;

        for (int i = 0; i < poolableObject.PoolSize; i++)
        {
            GameObject instance = GameObject.Instantiate(poolableObject.ObjectPrefab);

            instance.transform.parent = poolParent;

            poolQueue.Enqueue(instance);
        }

        return poolQueue;
    }

    public ObjectPool GetPool(string poolName)
    {
        // This could be improved using a dictionary
        ObjectPool output = new ObjectPool();

        foreach (var pool in pools)
        {
            if (string.Equals(pool.poolName, poolName))
            {
                output = pool;
            }
        }

        return output;
    }
}
