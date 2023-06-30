using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public class SceneController : MonoBehaviour
    {
        public enum SceneType
        {
            Splash,
            MainMenu,
            Gameplay
        }


        public IEnumerator LoadScene(SceneType sceneType)
        {
            yield break;
        }
        
       
        
        
    }
}