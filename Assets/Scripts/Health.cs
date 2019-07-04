using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Transform health;

    public Slider sld;

    public float MaxHealth;

    public float currentHealth;

    public float hboffset = 2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeHealth(int am) {
        currentHealth += am;
        currentHealth = Mathf.Clamp(currentHealth, 0, MaxHealth);

        sld.value = currentHealth / MaxHealth;
    }
}
