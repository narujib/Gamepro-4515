using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaArray : MonoBehaviour
{
    public string[] items;

    void Start()
    {
        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log (items[i]);
        }
    }

    void Update()
    {
        
    }
}
