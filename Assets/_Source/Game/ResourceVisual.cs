using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.ObjectModel;
using TMPro;

namespace _Source.Game
{

    public class ResourсeVisual:MonoBehaviour
    {
        [SerializeField] private ResourceBank bank;
        [SerializeField] private List<TMP_Text> resourceText;
        private readonly List<GameResource> _typesOfGameResources = new()
            { GameResource.Food, GameResource.Gold, GameResource.Humans, GameResource.Stone, GameResource.Wood };

        private void Awake()
        {
            foreach (GameResource resource in _typesOfGameResources)
            {
                bank.GetResource(resource).OnValueChanged += (value => resourceText[(int)resource].text = $"{value}");
            }
        }
        
    }
}