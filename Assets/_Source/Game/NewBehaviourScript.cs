using System;
using System.Collections;
using System.Collections.Generic;
using _Source.Game;

using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    List<ResourсeVisual> _resources = new List<ResourсeVisual>();
    void Start()
    {
        
        foreach (GameResource name in Enum.GetValues(typeof(GameResource)))
        {
            ResourсeVisual res = new ResourсeVisual();
            res.Resource = name;
            _resources.Add(res);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (ResourсeVisual res in _resources)
        {
            res.ChangeValue();
        }

    }
}
