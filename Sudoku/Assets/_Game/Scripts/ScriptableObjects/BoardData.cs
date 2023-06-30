using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Utils;

[CreateAssetMenu(fileName = "BoardData", menuName = "ScriptableObjects/BoardData", order = 1)]
public class BoardData : ScriptableObject
{
    [Header("Pools")] 
    public List<PoolableType> PoolableTypes;
}
