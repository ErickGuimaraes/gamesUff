﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Death : MonoBehaviour
{
    public GameObject player;
    public GameObject shot;

    private void OnTriggerEnter2D(Collider2D col){
        Destroy(col.gameObject);

        if(col.gameObject.tag == "tiroZumbi"){

            Debug.Log("ESTOU PERDENDO VIIIIIIDDDDAAAAAAA");
           
        }
    }

    void Start(){

    }

    void Update(){
        
    }
}
