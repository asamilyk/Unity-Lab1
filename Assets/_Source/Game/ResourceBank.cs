using System.Collections.Generic;
using UnityEngine;

namespace _Source.Game
{
    public class ResourceBank:MonoBehaviour
    {
         private readonly Dictionary<GameResource, ObservableInt> _resourceDict = new();

         public ResourceBank()
         {
             _resourceDict.Add(GameResource.Food, new ObservableInt(0));
             _resourceDict.Add(GameResource.Gold, new ObservableInt(0));
             _resourceDict.Add(GameResource.Humans, new ObservableInt(0));
             _resourceDict.Add(GameResource.Stone, new ObservableInt(0));
             _resourceDict.Add(GameResource.Wood, new ObservableInt(0));
         }
         
         
         /// <summary>
         /// increases the value of the resource r from the dictionary by v
         /// </summary>
         /// <param name="r">resource</param>
         /// <param name="v">value</param>
         public void ChangeResource(GameResource r, int v)
        {
            if (_resourceDict.TryGetValue(r, out var value))
            {
                value.Value += v;
            }
            else
            {
                _resourceDict[r] = new ObservableInt(v);
            }
        }

        public ObservableInt GetResource(GameResource r)
        {
            if (_resourceDict.TryGetValue(r, out var resource))
            {
                return resource;
            }

            _resourceDict[r].Value = 0;
            return _resourceDict[r];
        }
    }
}