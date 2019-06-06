using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public GameObject zombie;
    public GameObject shot;

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "tr1")
        {
            Destroy(col.gameObject);
            print(col.gameObject.name);
            Destroy(zombie);
        }
    }

    
}
