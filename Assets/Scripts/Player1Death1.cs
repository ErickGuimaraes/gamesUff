using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Death1 : MonoBehaviour
{
    public GameObject player;
    public GameObject shot;

   
    private void OnTriggerEnter(Collider col){


        if(col.gameObject.tag == "tiroZumbi"){

            Debug.Log(col.name + "NAOMEMOMAODMS");

            Destroy(col.gameObject);
            player.SendMessage("dano");
            player.SendMessage("getHP");

        }

        if (col.gameObject.tag == "deathB")
        {

            Debug.Log(col.name + "NAOMEMOMAODMS");

            Destroy(col.gameObject);
            player.SendMessage("dano");
            player.SendMessage("getHP");


        }
    }

}
