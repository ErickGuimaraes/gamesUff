using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer2Controller : MonoBehaviour {

    private Vector3 Npos;
    
    public float speed;
    public float upSpeed;
    public float Gravity;
    public float MaxSpeed;
    public float Acceleration;
    public float Deceleration;
    public float shotSpeed;
    public float Shot2Release;
    public float Shot3Release;
    public float jumpSpeed;

    private Rigidbody rb; 

    public bool grd;

    public GameObject shot;
    public GameObject shot2;
    public GameObject shot3;
    public GameObject pos;

    private float del;
    private bool bulletCheck;
    float contPU;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        bulletCheck = false;
        del = 0;
        upSpeed = 0;
        //grd = true;
        rb.freezeRotation = true;


    }

    void Update()
    {
       

        if (Input.GetKey(KeyCode.LeftArrow) && (speed < MaxSpeed))
        {
            speed = speed - Acceleration * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.RightArrow) && (speed > -MaxSpeed))
        {
            speed = speed + Acceleration * Time.deltaTime;
        }
        else
        {
            if (speed > Deceleration * Time.deltaTime)
            {
                speed = speed - Deceleration * Time.deltaTime;
            }
            else if (speed < -Deceleration * Time.deltaTime)
            {
                speed = speed + Deceleration * Time.deltaTime;
            }
            else
            {
                speed = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && (upSpeed == 0))
        {

            isNotGrounded();
            upSpeed = jumpSpeed;
        }
        
        if (grd == false)
        {
            upSpeed -= Gravity * Time.deltaTime;

        }
        else {
            upSpeed = 0;
        }

        Vector3 v = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y + upSpeed*Time.deltaTime, gameObject.transform.position.z);

        gameObject.transform.position = v;

        if (!bulletCheck)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {

                GameObject.Instantiate(shot, pos.transform.position, shot.transform.rotation);
                bulletCheck = true;
                contPU += Time.deltaTime;
            }
        }
        else
        {
            del += Time.deltaTime;
        }
        if(contPU != 0)
        {
            contPU += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {

            if (contPU > Shot2Release && contPU < Shot3Release)
            {

                GameObject.Instantiate(shot2, pos.transform.position, shot2.transform.rotation);

            }
            else if (contPU > Shot3Release)
            {

                GameObject.Instantiate(shot3, pos.transform.position, shot3.transform.rotation);
                
            }
            contPU = 0;
        }

        if (del > shotSpeed) {
            bulletCheck = false;
            del = 0;
        }

    }

    private void isGrounded()
    {
        grd = true;
    }

    private void isNotGrounded()
    {
        grd = false;
        
    }

   
}