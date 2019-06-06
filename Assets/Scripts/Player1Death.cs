using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Death : MonoBehaviour
{
    public GameObject player;
    public GameObject shot;

    private void OnTriggerEnter2D(Collider2D col){
        
        if(col.gameObject.tag == "tiroZumbi"){

            player.SendMessage("dano");
            player.SendMessage("getHP");
            Destroy(col.gameObject);

        }//else if(col.player)
    }

    void Start(){

    }

    void Update(){
        
    }
}
