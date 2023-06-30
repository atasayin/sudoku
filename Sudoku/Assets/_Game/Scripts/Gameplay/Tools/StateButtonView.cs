using Gameplay.Cell;
using TMPro;
using UnityEngine;
using Utils.MonoBehaviors;

namespace Gameplay.Tools
{
    public class StateButtonView : InitMono<CellState>
    {
        [SerializeField] private TextMeshProUGUI NumberText;

        public override void Initialize(CellState number)
        {
            var text = number == CellState.Empty ? "X" : ((int)number).ToString();
            NumberText.text = text;
        }
    }
}