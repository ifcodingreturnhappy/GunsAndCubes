using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Poolable Object")]
    public class PoolableObject : ScriptableObject
    {
        public string PoolName;
        public GameObject ObjectPrefab;
        public int PoolSize;
    }
}
