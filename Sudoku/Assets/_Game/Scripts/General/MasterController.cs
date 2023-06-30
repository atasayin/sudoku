using System;
using System.Collections;
using Gameplay;
using UnityEngine;
using UnityEngine.Serialization;
using Utils;
using Utils.MonoBehaviors;

namespace General
{
    public class MasterController : Singleton<MasterController>
    {
        [SerializeField] private ObjectController ObjectController; 
        [SerializeField] private SceneController SceneController;

        private ScreenData _screenData;
        
    }
}