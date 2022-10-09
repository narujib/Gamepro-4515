using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    public float speed;
    Vector3 kebawah;
    
    void Start()
    {
        kebawah = new Vector3(0, -1, 0);
    }
    
    void Update()
    {
        transform.position = transform.position + (kebawah * speed * Time.deltaTime);
    }
}
