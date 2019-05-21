using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            MoveCima();
        }

        if (Input.GetKey(KeyCode.S)){
            MoveBaixo();
        }
        
        if(Input.GetKey(KeyCode.A)){
            MoveEsquerda();
        }

        if(Input.GetKey(KeyCode.D)){
            MoveDireita();
        }
    }

    void MoveCima(){
        transform.Translate((-velocidade * Time.deltaTime), 0, 0);
    }
    void MoveBaixo(){
        transform.Translate((velocidade * Time.deltaTime), 0, 0);
    }
    void MoveEsquerda(){
        transform.Translate(0, (-velocidade * Time.deltaTime), 0);
    }
    void MoveDireita(){
        transform.Translate(0, (velocidade * Time.deltaTime), 0);
    }
}
