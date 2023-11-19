using System;
using UnityEngine;

namespace _Source.Game
{
    public class GameManager:MonoBehaviour
    {
        private void Awake()
        {
            ResourceBank.ChangeResource(GameResource.Humans, 10);
            ResourceBank.ChangeResource(GameResource.Food, 5);
            ResourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }
}