using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
namespace _Source.Game
{
    public class CoroutineSlider:MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Image image;
        [SerializeField] private ProductionBuilding _builder;
        
        [SerializeField] private float _start = 0.00f;
        

        /// <summary>
        /// Filling in the progress bar
        /// </summary>
        public void Fill()
        {
            _button.interactable = false;
            int steps = Convert.ToInt32(_builder.ProductionTime * 100);
            StartCoroutine(FillCoroutine(steps));
        }
        
        /// <summary>
        /// Сhanges for the progress bar
        /// </summary>
        /// <param name="dist"></param>
        private void ProgressStep(float dist)
        {
            image.fillAmount = _start;
            _start += dist;
            
        }
        
        /// <summary>
        /// Сoroutine for the progress bar
        /// </summary>
        /// <param name="steps"></param>
        /// <returns></returns>
        IEnumerator FillCoroutine(int steps)
        {
            float dist = 1.0f / steps;
            for (int i = 0; i < steps; i++)
            {
                ProgressStep(dist);
                yield return new WaitForEndOfFrame();
            }
            _start = 0;
            image.fillAmount = dist;
            _button.interactable = true;
            yield return new WaitForEndOfFrame();
        }
    }
}