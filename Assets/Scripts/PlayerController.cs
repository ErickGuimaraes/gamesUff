using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int hp;
    public float velocidade;
    public GameObject tiro;
    public GameObject pos;
    public float rajada;
    public float xmin, ymin, ymax;
    private bool shootTimer;
    private float timer;
    private int contKills;
    public GameObject Boss;
    
    void Start()
    {
        shootTimer = false;
        timer = 0;
        contKills = 0;
        Boss = GameObject.FindGameObjectWithTag("boss");
    }
    void Update()
    {
        if(hp == 0){
            gameOver();
        }
        
        if (Input.GetKey(KeyCode.UpArrow)){
            MoveCima();
        }

        if (Input.GetKey(KeyCode.DownArrow)){
            MoveBaixo();
        }
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            MoveEsquerda();
        }

        if(Input.GetKey(KeyCode.RightArrow)){
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

        if (contKills >= 10) {
            Debug.Log("NASCI BOSS");
            Boss.SendMessage("Spawn");
            contKills = -20;
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

    public void dano(){
        hp--;
    }

    public void getHP(){
        print(hp);
        //return hp;
    }

    public void gameOver() {

        SceneManager.LoadScene("Game Over");
    }

    public void increaseKills() {
        contKills++;
    }
}
