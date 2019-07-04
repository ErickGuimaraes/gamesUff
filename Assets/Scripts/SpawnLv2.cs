using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLv2 : MonoBehaviour
{
    public GameObject monster;
    public Transform pos;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "player") {

            Vector3 rot = monster.transform.eulerAngles;
            rot = new Vector3(-90, -90, 0);
            // Vector3 v = (transform.position.pos.x, pos.y, pos.z) ;
            Instantiate(monster, pos.transform.position, Quaternion.Euler(rot)) ;
            Rigidbody rb = monster.GetComponent<Rigidbody>();
            //rb.freezeRotation = true;
            Destroy(gameObject);
        }
    }

}
