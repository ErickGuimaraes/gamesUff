using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFall : MonoBehaviour
{


    public GameObject player;


    private void OnCollisionEnter(Collision col)
    {

        
        if (col.gameObject.tag == "player")
        {

            player.SendMessage("death");


        }
    }
}