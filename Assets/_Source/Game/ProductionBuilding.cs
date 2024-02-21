using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Game
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] private ResourceBank _resourceBank;
        [SerializeField] private GameResource _resource;
        [SerializeField] private float _productionTime = 1.0f;

        public void Increase()
        {
            StartCoroutine(IncreaseCoroutine());
        }
        public float ProductionTime
        {
            get => _productionTime;
        }
        
        /// <summary>
        /// The coroutine, which, after the passage of ProductionTime, increased the corresponding resource by 1
        /// </summary>
        /// <returns></returns>
        private IEnumerator IncreaseCoroutine()
        {
            yield return new WaitForSeconds(ProductionTime);
            _resourceBank.ChangeResource(_resource, 1);
        }
        
    }
}