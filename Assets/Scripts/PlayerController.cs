using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade;
    public GameObject tiro;
    public GameObject pos;
    public float rajada;
    public float xmin, ymin, ymax;
    private bool shootTimer;
    private float timer;
    
    void Start()
    {
        shootTimer = false;
        timer = 0;
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
        if(Input.GetKey(KeyCode.C)){
            if(shootTimer == false){
                atira();
                shootTimer = true;
            }

        }
        timer += Time.deltaTime;
        if(timer > rajada){
            shootTimer = false;
            timer = 0;
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
    void atira(){
        Instantiate(tiro, pos.transform.position, tiro.transform.rotation);
    }
}
