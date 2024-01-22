using System;
using UnityEngine;

namespace _Source.Game
{
    public class GameManager:MonoBehaviour
    {
        [SerializeField] private ResourceBank _resourceBank;
        private void Start()
        {
            _resourceBank.ChangeResource(GameResource.Humans, 10);
            _resourceBank.ChangeResource(GameResource.Food, 5);
            _resourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }
}