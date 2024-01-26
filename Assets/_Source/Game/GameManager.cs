using System;
using UnityEngine;

namespace _Source.Game
{
    public class GameManager:MonoBehaviour
    {
        [SerializeField] private ResourceBank resourceBank;
        private void Start()
        {
            resourceBank.ChangeResource(GameResource.Humans, 10);
            resourceBank.ChangeResource(GameResource.Food, 5);
            resourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }
}