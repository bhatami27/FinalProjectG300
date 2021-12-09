using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxPuzzle : MonoBehaviour
{
    public Transform player;
    private int currentSceneIndex;
    public GameObject puzzle1, puzzle2, puzzle3;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }   
    }

    void LoadPuzzle()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SaveScene", currentSceneIndex);
        SceneManager.LoadScene(1);
    }
}
