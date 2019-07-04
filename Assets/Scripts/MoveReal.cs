using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveReal : MonoBehaviour
{
    private CharacterController ctrl;

    public float verticalVelocity;
    public float gravity = 14f;
    public float jumpforce = 10f;
    public int speed;

    public float hp;

    private Rigidbody rb;
    private bool bulletCheck;

    public GameObject shot;
    public GameObject shot2;
    public GameObject shot3;
    public GameObject pos;

    private float del;
    float contPU;

    public float shotSpeed;
    public float Shot2Release;
    public float Shot3Release;

    public GameObject camera;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        bulletCheck = false;
        ctrl = GetComponent<CharacterController>();
        rb.freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pp = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -37);
        camera.transform.position = pp;

        if (ctrl.isGrounded)
        {

            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpforce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 mov = Vector3.zero;//  new Vector3(0,verticalVelocity,0);
        mov.x = Input.GetAxis("Horizontal") * speed;
        mov.y = verticalVelocity;
        mov.z = 0f;// Input.GetAxis("Vertical");
        ctrl.Move(mov * Time.deltaTime);
        if (mov.z < -1)  mov.z = -1;
     //   camera.transform.position = (mov * Time.deltaTime);


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
        if (contPU != 0)
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

        if (del > shotSpeed)
        {
            bulletCheck = false;
            del = 0;
        }

    }
    private void dano()
    {
        hp--;
    }

    public void getHP()
    {
        print(hp);
    }

    public void death()
    {

        SceneManager.LoadScene("game over");

    }
}
