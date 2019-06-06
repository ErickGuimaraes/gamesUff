using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour
{
    public GameObject pl;
    public GameObject floor;


    private void OnCollisionEnter(Collision pe)
    {

    
        if (pe.gameObject.tag == "pe")
        {

            print("AHAHAHAHA");
            pl.SendMessage("isGrounded");


        }
    }

    private void OnCollisionExit(Collision pe)
    {

        if (pe.gameObject.tag == "pe")
        {
            pl.SendMessage("isNotGrounded");
            print("saiu");


        }
    }

}
