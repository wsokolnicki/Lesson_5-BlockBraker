using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks; //Serialized for debuging puposes

    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    private void Update()
    {
        RestartLevel();
    }

    private void RestartLevel()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            sceneloader.RestartScene();
        }
    }

    public void CountBlocks()
    {
             breakableBlocks++;
    }
     
    public void BlockDestroyed ()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }

}
