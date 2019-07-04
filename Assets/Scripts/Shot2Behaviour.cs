using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot2Behaviour : MonoBehaviour
{
    public float speed;

    private float del;

    // Start is called before the first frame update
    void Start()
    {

        del = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.eulerAngles.z == 90)
        {
            Vector3 v = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = v;
        }
        //transform.Translate(0, gameObject.transform.position.y + (speed * Time.deltaTime), 0);
        else if (gameObject.transform.eulerAngles.z == 270)
        {
            Vector3 v = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = v;
        }
        //transform.Translate(0, gameObject.transform.position.y + (-speed * Time.deltaTime), 0);

        //Vector3 v = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        //  gameObject.transform.position = v;

        del += Time.deltaTime;

        if (del > 2) {
            Destroy(gameObject);
        }

    }
}
