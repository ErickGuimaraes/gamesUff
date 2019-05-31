using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour
{
    public GameObject pl;
    public GameObject floor;

    void OnTriggerEnter()
    {

        if (floor.gameObject.tag == "floor")
        {
            pl.SendMessage("isGrounded");

        }

    }

    private void OnTriggerExit()
    {
        pl.SendMessage("isNotGrounded");
    }

}
