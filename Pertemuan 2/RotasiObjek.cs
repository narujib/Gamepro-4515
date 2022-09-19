using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiObjek : MonoBehaviour
{
    Vector3 maju;
    Vector3 mundur;

    void Start()
    {
        maju   = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(maju * 50f * Time.deltaTime);
    }
}
