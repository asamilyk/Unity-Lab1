using System;
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
        public float ProductionTime => _productionTime;

        /// <summary>
        /// The coroutine, which, after the passage of ProductionTime, increased the corresponding resource by 1
        /// </summary>
        /// <returns></returns>
        private IEnumerator IncreaseCoroutine()
        {
            yield return new WaitForSeconds(ProductionTime);
            int addNumber = _resourceBank.GetResource(_resourceBank.GetLevel(_resource)).Value;
            _resourceBank.ChangeResource(_resource, addNumber);
        }

        /// <summary>
        /// Сalculating the production rate of a resource using the formula
        /// </summary>
        /// <returns></returns>
        private float GetSpeed()
            => Math.Max(_productionTime * (
                1.01f - _resourceBank.GetResource(
                    _resourceBank.GetLevel(_resource)).Value / 100.0f), 0.01f);
        
    }
}