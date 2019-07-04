using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject boss;
    public GameObject direita;
    public GameObject esquerda;
    public float velocidade;
    public float limiteSup;
    public float limiteInf;

    // Start is called before the first frame update
    void Start()
    {

        move();
    }

    // Update is called once per frame
    void Update()
    {

        if (direita.transform.position.y <= limiteSup){
            Debug.Log(esquerda.transform.position.y);

            velocidade = velocidade * -1;
        }

        if (esquerda.transform.position.y >= limiteInf) {
            Debug.Log(esquerda.transform.position.y);
            
            velocidade = velocidade * -1;
        }

        move();
    }

    void move(){
        boss.transform.Translate((velocidade * Time.deltaTime), 0, 0);
    }
}
