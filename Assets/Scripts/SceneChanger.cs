using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class SceneChanger : MonoBehaviour
{
    public string scn;

    public void onClick()
    {
        SceneManager.LoadScene(scn, LoadSceneMode.Single);
    }
}
