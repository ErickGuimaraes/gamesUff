using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BssShot : MonoBehaviour
{
    public GameObject tiro;
    public GameObject pos;
    public float velocidade;
    private bool shootTimer;
    private float timer;
    public float tmControl = 1;
    // Start is called before the first frame update
    void Start()
    {
        shootTimer = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootTimer == false)
        {
            atira();
            shootTimer = true;
        }

        timer += Time.deltaTime;
        if (timer > tmControl)
        {
            shootTimer = false;
            timer = 0;
        }
    }

    void atira()
    {
        Instantiate(tiro, pos.transform.position, tiro.transform.rotation);
    }
}