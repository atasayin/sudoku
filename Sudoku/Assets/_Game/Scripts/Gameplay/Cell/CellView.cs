using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Cell
{
    public class CellView : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private CellPresenter CellPresenter;
        [SerializeField] private TextMeshProUGUI Number;
        [SerializeField] private GameObject CircleObject;
        
        public void OnPointerClick(PointerEventData eventData)
        {
            CellPresenter.Pressed();
        }

        public void ChangeNumberText(int number)
        {
            CircleObject.SetActive(true);
            Number.text = number.ToString();
        }

        public void CloseNumber()
        {
            CircleObject.SetActive(false);
        }
    }
}