using System;

namespace Gameplay.Cell
{
    public class CellModel
    {
        public event Action OnCellPressed;
        public CellState CellState { get; private set; }

        public CellModel()
        {
            CellState = CellState.Empty;
        }
        
        public CellModel(CellState cellState)
        {
            CellState = cellState;
        }
        
        public bool IsErase()
        {
            return CellState == CellState.Empty;
        }
        
        public void ChangeState()
        {
            var gameplayController = GameplayController.Instance;
            CellState = gameplayController.PressState;
            UpdateCell();
        }
        
        private void UpdateCell()
        {
            OnCellPressed?.Invoke();
        }
    }
}