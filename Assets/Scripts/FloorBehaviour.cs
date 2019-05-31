using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour
{
    public GameObject pl;
    public GameObject floor;


    private void OnCollisionEnter(Collision pe)
    {


            pl.SendMessage("isGrounded");



    }

    private void OnCollisionExit(Collision pe)
    {

            print("saiu");
            pl.SendMessage("isNotGrounded");

    }

}
