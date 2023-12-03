using Unity.VisualScripting;
using UnityEngine;
using System.Collections.ObjectModel;

namespace _Source.Game
{
    public class ResourсeVisual:MonoBehaviour
    {
        private static GameResource _resource;
        public GameResource Resource
        {
            set => _resource = value;
            get => _resource;
        }
        
        public void ChangeValue()
        {
            ObservableCollection<int> resourceAmount = ResourceBank.GetResource(_resource);
        }
        
    }
}