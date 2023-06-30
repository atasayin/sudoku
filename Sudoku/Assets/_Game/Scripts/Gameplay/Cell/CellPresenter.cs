using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Cell
{
    public class CellPresenter : MonoBehaviour
    {
        [SerializeField] private CellView CellView;
        private CellModel _cellModel;

        private void Awake()
        {
            _cellModel = new CellModel();
        }

        private void OnEnable()
        {
            _cellModel.OnCellPressed += UpdateUI;
        }
        
        private void OnDisable()
        {
            _cellModel.OnCellPressed -= UpdateUI;
        }

        public void Pressed()
        {
            _cellModel.ChangeState();
        }
        
        private void UpdateUI()
        {
            if (!_cellModel.IsErase())
            {
                var number = _cellModel.CellState;
                CellView.ChangeNumberText((int)number);
            }
            else
            {
                CellView.CloseNumber();
            }
        }
    }
}