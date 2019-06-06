using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Death1 : MonoBehaviour
{
    public GameObject player;
    public GameObject shot;

   
    private void OnTriggerEnter(Collider col){

        print("AAAAssteste");

        if(col.gameObject.tag == "tiroZumbi"){
            
            Destroy(col.gameObject);
            player.SendMessage("dano");
            player.SendMessage("getHP");


        }
    }

    void Start(){

    }

    void Update(){
        
    }
}
