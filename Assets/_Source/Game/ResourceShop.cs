using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Diagnostics;

namespace _Source.Game
{
    public class ResourceShop : MonoBehaviour
    {
        [SerializeField] private GameResource _resource;
        [SerializeField] private ResourceBank _bank;
        [SerializeField] private Button _button;
        [SerializeField] private TMP_Text _text;
         private int _currPrice = 5;

        private int Price => _currPrice * _bank.GetResource(_bank.GetLevel(_resource)).Value;

        void Start()
        {
            _text.text = $"{_resource.ToString()}\n {Price} coins";
        }

        /// <summary>
        /// Allows to improve the resource level
        /// </summary>
        public void Improve()
        {
            if (_bank.GetResource(_resource).Value >= Price)
            {
                FillButtom(Color.magenta);
                _bank.GetResource(_resource).Value -= Price;
                _bank.GetResource(_bank.GetLevel(_resource)).Value++;
            }
            else
            {
                FillButtom(Color.red);
            }

            _text.text = $"{_resource.ToString()}\n ({Price} coins)";
        }

        /// <summary>
        /// Paints the button in the desired color
        /// </summary>
        /// <param name="color"></param>
        private void FillButtom(Color color)
        {
            _button.interactable = false;
            StartCoroutine(FillButtomCoroutine(color));
        }

        private IEnumerator FillButtomCoroutine(Color color)
        {
            _button.image.color = color;
            int timeForColor = 50;
            for (int i = 0; i < timeForColor; ++i)
            {
                yield return new WaitForEndOfFrame();
            }

            _button.image.color = Color.white;
            _button.interactable = true;
            yield return new WaitForEndOfFrame();
        }
    }
}