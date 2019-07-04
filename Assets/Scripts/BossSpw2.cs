using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpw2 : MonoBehaviour
{

    public GameObject monster;
    //public Transform pos;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "player")
        {

            monster.SetActive(true);
            Destroy(gameObject);
        }
    }

}

