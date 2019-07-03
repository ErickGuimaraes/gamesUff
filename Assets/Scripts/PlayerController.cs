using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public int hp;
    public float velocidade;
    public GameObject tiro;
    public GameObject pos;
    public float rajada;
    public float xmin, ymin, ymax;
    public int killsToBoss;
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
        if(hp <= 0){
            gameOver();
        }
        
        if (Input.GetKey(KeyCode.UpArrow)){
            if(player.transform.position.y < ymax){
                MoveCima();
            }
        }

        if (Input.GetKey(KeyCode.DownArrow)){
            if(player.transform.position.y > ymin){
                MoveBaixo();
            }
        }
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            if(player.transform.position.x > xmin){
                MoveEsquerda();
            }
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

        if (contKills >= killsToBoss) {
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

    public void danoBoss(){
        hp = hp - 3;
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
