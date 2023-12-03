using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity.VisualScripting;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceBank:MonoBehaviour
    {
         static Dictionary<GameResource, ObservableCollection<int>> _resourceDict;
        public static void ChangeResource(GameResource r, int v)
        {
            _resourceDict[r].Add(v);
        }

        public static ObservableCollection<int> GetResource(GameResource r)
        {
            return _resourceDict[r];
        }
    }
}