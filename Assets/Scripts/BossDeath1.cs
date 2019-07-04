using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDeath1 : MonoBehaviour
{
    public GameObject boss;
    public GameObject shot;



    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "tr1")
        {
            Destroy(col.gameObject);
            print(col.gameObject.name);
            gameObject.SendMessage("hit");
        }
    }
}


