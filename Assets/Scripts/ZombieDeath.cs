﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public GameObject zombie;
    public GameObject shot;

    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        if (col.gameObject.tag == "tr1")
        {
            Destroy(zombie);
        }
    }
    
}
