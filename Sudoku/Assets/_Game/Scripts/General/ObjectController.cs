using System.Collections.Generic;
using UnityEngine;
using Utils;
using Utils.MonoBehaviors;

namespace General
{
    public class ObjectController : InitMono
    {
        [SerializeField] private ObjectPooler ObjectPooler;
        [SerializeField] private BoardData BoardData;
        
        public override void Initialize()
        {
            InitObjectPool();
        }
        
        private void InitObjectPool()
        {
            List<PoolableType> poolableTypes = BoardData.PoolableTypes;
            ObjectPooler.Initialize(poolableTypes);
        }

    }
}