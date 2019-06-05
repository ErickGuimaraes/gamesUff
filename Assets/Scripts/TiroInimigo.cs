using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    public float velocidade;
    void Update()
    {
        moveTiro();
    }

    void moveTiro(){
        transform.Translate((-velocidade * Time.deltaTime),0,0);
    }
}
