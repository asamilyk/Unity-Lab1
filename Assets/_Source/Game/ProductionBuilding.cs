using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Game
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] private ResourceBank _resourceBank;
        [SerializeField] private GameResource _resource;
        
        public void Increase()
        {
            _resourceBank.ChangeResource(_resource, 1);
        }
        
    }
}