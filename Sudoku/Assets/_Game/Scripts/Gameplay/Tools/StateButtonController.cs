using System;
using Gameplay.Cell;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tools
{
    public class StateButtonController : MonoBehaviour
    {
        [SerializeField] public CellState ButtonPressState;
        [SerializeField] private Button Button;
        [SerializeField] private StateButtonView StateButtonView;
        private void Awake()
        {
            Button.onClick.AddListener(OnClick);
            StateButtonView.Initialize(ButtonPressState);
        }
        
        public void OnClick()
        {
            var gameplayController = GameplayController.Instance;

            if (gameplayController is null)
            {
                return;
            }
            
            gameplayController.PressState = ButtonPressState;
        }
    }
}