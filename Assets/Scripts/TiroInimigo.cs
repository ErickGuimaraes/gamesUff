using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    public float velocidade;
    private float control = 0;
    void Update()
    {
        control += Time.deltaTime;
        moveTiro();

        if (control >= 3) {
            Destroy(gameObject);
        }
    }

    void moveTiro(){
        transform.Translate((-velocidade * Time.deltaTime),0,0);
    }
}
