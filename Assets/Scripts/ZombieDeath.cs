using System.Collections;
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
    
    /*
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "tiro")
        {
            
            
            Destroy(zombie);
        }


    }
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
