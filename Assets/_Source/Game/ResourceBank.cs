using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity.VisualScripting;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceBank:MonoBehaviour
    {
        static Dictionary<GameResource, ObservableCollection<int>> _resourceDict;
        public static System.Action HumanValueChanged;
        public static void ChangeResource(GameResource r, int v)
        {
            if (r is GameResource.Humans)
            {
                HumanValueChanged?.Invoke();
            }
            _resourceDict[r].Add(v);
        }

        static ObservableCollection<int> GetResource(GameResource r)
        {
            return _resourceDict[r];
        }
    }
}