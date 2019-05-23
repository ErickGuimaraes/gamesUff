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
        Vector3 v = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = v;

        del += Time.deltaTime;

        if (del > 2) {
            Destroy(gameObject);
        }

    }
}
