using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    [Serializable]
    public class ObjectPool
    {
        [Header("This is a read-only class, to display the pools.")] // Must implement custom editor script
        public string poolName;

        public int poolSize;

        public Queue<GameObject> pool;
    }
}
