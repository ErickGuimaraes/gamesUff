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

    void moveTiro(){
        transform.Translate(0,(velocidade * Time.deltaTime),0);
    }
}
