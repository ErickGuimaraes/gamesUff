using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public GameObject boss;
    public GameObject direita;
    public GameObject esquerda;
    public float velocidade;
    float limiteSup = -1.0f;
    float limiteInf = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(direita.transform.position.x <= limiteSup || esquerda.transform.position.x >= limiteInf){
            velocidade = velocidade * -1;
        }
        move();
    }

    void move(){
        boss.transform.Translate((velocidade * Time.deltaTime), 0, 0);
    }
}
