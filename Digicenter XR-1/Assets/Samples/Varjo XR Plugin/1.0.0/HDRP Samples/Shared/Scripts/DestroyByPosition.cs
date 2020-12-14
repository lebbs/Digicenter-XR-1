﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByPosition : MonoBehaviour
{
    public float destroyPositionY = -1;
    public float destroyPositionZ = -1;
    void Update()
    {
        if(transform.position.y < destroyPositionY ||
            transform.position.z < destroyPositionZ) 
        {
            Destroy(this.gameObject); //Destroy gameobject if fallen 10 meters below ground level
        }
    }
}
