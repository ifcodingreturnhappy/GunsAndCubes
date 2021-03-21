using System;
using UnityEngine;

[Serializable]
public class GameBehaviour : MonoBehaviour
{
    public virtual void Initialize() { }
    public virtual void Execute() { }
}
