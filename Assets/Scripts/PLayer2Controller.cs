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

    private Rigidbody rb; 

    public bool grd;

    public GameObject shot;
    public GameObject pos;

    private float del;
    private bool bulletCheck;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        bulletCheck = false;
        del = 0;
        grd = true;

    }

    void Update()
    {
         rb.freezeRotation = true;

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
            upSpeed = 8.5f;
            grd = false;
        }
        if (grd == false)
        {
            upSpeed -= Gravity * Time.deltaTime;
            if (upSpeed < -8.4f) {
                grd = true;
            }
            
        }
        else {
            upSpeed = 0;
        }

        Vector3 v = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y + upSpeed*Time.deltaTime, gameObject.transform.position.z);

        gameObject.transform.position = v;


        Debug.Log(upSpeed);




        if (!bulletCheck)
        {
            if (Input.GetKey(KeyCode.C))
            {
                GameObject.Instantiate(shot, pos.transform.position, shot.transform.rotation);
                bulletCheck = true;
            }
        }
        else {
            del += Time.deltaTime;
        }

        if (del > 0.3) {
            bulletCheck = false;
            del = 0;
        }

    }
}