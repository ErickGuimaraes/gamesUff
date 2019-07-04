using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo1 : MonoBehaviour
{
    public float velocidade;
    void Update()
    {
        moveTiro();
    }

    void moveTiro() {
        if (gameObject.transform.eulerAngles.z == 90)
           transform.Translate(0, (velocidade * Time.deltaTime), 0);
        else if (gameObject.transform.eulerAngles.z == 270)
            transform.Translate(0, (-velocidade * Time.deltaTime), 0);
    }
}
