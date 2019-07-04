using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDeath : MonoBehaviour
{
    public int life;
    public GameObject boss;
    public GameObject shot;

    

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "tr1")
        {
            life = life - 1;
            Destroy(col.gameObject);
            print(col.gameObject.name);
            if(life == 0){
                Destroy(boss);
                SceneManager.LoadScene("level 2");

            }
        }
    }
}
