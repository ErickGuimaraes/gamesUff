using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health1 : MonoBehaviour
{
    public Slider hb;
    public int health;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hb.value = health;
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("tiroZumbi")) { if (health > 0) {
                print("aaaa");
                health = health - 10;
            }
        }
        if (col.gameObject.tag == ("tiroBoss")) { if (health > 0) health = health - 25; }
    }
}
