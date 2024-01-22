using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.ObjectModel;
using TMPro;

namespace _Source.Game
{

    public class ResourсeVisual:MonoBehaviour
    {
        [SerializeField] private ResourceBank _bank;
        [SerializeField] private List<TMP_Text> _resourceText;
        private readonly List<GameResource> _typesOfGameResources = new()
            { GameResource.Food, GameResource.Gold, GameResource.Humans, GameResource.Stone, GameResource.Wood };

        private void Awake()
        {
            foreach (GameResource resource in _typesOfGameResources)
            {
                _bank.GetResource(resource).OnValueChanged += value => _resourceText[(int)resource].text = $"{value}";
            }
        }
        
    }
}