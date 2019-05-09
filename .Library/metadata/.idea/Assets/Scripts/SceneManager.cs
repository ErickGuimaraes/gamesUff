using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class SceneManager : MonoBehaviour
{
    public string scn;

    public void onClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scn, LoadSceneMode.Single);
    }
}
