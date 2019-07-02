using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Death : MonoBehaviour
{
    public GameObject player;
    public GameObject shotZombie;
    public GameObject shotBoss;


    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "tiroZumbi")
        {
            player.SendMessage("dano");
            player.SendMessage("getHP");
            Destroy(col.gameObject);

        }
        if (col.gameObject.tag == "tiroBoss"){
            player.SendMessage("danoBoss");
            player.SendMessage("getHP");
            Destroy(col.gameObject);
        }
    }

}
