using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public GameObject zombie;
    public GameObject shot;

    private void OnTriggerEnter2D(Collider2D col)
    {
        print("ai pai para");
        Destroy(col.gameObject);
        Destroy(zombie);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
