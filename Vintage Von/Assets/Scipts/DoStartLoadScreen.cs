using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoStartLoadScreen : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene(5);
    }
}
