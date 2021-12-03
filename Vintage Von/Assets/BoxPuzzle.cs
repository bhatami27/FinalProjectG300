using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxPuzzle : MonoBehaviour
{
    public Transform player;
    private int currentSceneIndex;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            LoadPuzzle();
        }   
    }

    void LoadPuzzle()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SaveScene", currentSceneIndex);
        SceneManager.LoadScene(1);
    }
}
