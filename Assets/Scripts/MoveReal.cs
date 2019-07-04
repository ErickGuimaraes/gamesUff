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
        if (Input.GetKeyDown(KeyCode.A)) {
            gameObject.transform.eulerAngles = new Vector3(0, 270, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        mov.y = verticalVelocity;
        mov.z = 0f;// Input.GetAxis("Vertical");
        ctrl.Move(mov * Time.deltaTime);
        if (mov.z < -1)  mov.z = -1;
     //   camera.transform.position = (mov * Time.deltaTime);


        if (!bulletCheck)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (gameObject.transform.eulerAngles.y == 90)
                {
                    Vector3 rot = gameObject.transform.eulerAngles;
                    rot = new Vector3(rot.x, rot.y, rot.z);
                    Debug.Log(rot);
                    GameObject.Instantiate(shot, pos.transform.position, shot.transform.rotation);
                }
                else if (gameObject.transform.eulerAngles.y == 270)
                {
                    Debug.Log("estou aqui");
                    Vector3 rot = shot.transform.eulerAngles;
                    rot = new Vector3(rot.x, rot.y, rot.z+180);
                    Debug.Log(rot);
            
                    GameObject.Instantiate(shot, pos.transform.position, Quaternion.Euler(rot));
                }
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
        if (Input.GetKeyUp(KeyCode.Mouse0))
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
        if (hp <= 0)
        {
            death();
        }

    }
    private void dano()
    {
        hp -= 5;
    }

    public void danoBoss()
    {
        hp = hp - 15;
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
