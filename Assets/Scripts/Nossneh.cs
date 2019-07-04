using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Nossneh : MonoBehaviour
{
    public int vida = 10;

    public GameObject direita;
    public GameObject esquerda;
    public float velocidade;
    public float limiteSup;
    public float limiteInf;
    bool trocou;

    // Start is called before the first frame update
    void Start()
    {
        trocou = false;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
         if (vida == 0) {
            Destroy(gameObject);
            SceneManager.LoadScene("Final");
        }


            if (direita.transform.position.y >= limiteSup)
        {

            print(direita.transform.position.y);
            print("aaa");

            velocidade = velocidade * -1;
                trocou = true;
            
        }



            if (esquerda.transform.position.y <= limiteInf)
            {
                if (trocou)
                    print(direita.transform.position.y);
                print("vvd");

                velocidade = velocidade * -1;
                trocou = false;
            
        }

        move();
    }

    public void hit() {
        vida--;
    }

    void move()
    {
        gameObject.transform.Translate(0,(velocidade * Time.deltaTime),  0);
    }
}
