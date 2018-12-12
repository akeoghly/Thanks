using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Level_One : MonoBehaviour
{
    public string Destination_Scene;


    public void NextScene()
    {
        SceneManager.LoadScene(Destination_Scene);
    }
}