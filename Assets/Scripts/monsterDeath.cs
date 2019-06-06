using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterDeath : MonoBehaviour
{

    public GameObject zombie;
    public GameObject shot;

    

    private void OnCollisionEnter(Collision col)
    {
      
        
        if (col.gameObject.tag == "tr1")
        {
            Destroy(col.gameObject);
            print(col.gameObject.name);
            Destroy(zombie);
        }
    }
}
