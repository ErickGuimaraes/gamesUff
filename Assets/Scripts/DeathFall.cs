using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFall : MonoBehaviour
{


    public GameObject player;


    private void OnTriggerEnter(Collider col)
    {

        Debug.Log("VAi se fuder ww");
        
        if (col.gameObject.tag == "player")
        {
            Debug.Log("MEU CU ");
            player.SendMessage("death");


        }
    }
}