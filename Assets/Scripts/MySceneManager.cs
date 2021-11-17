using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    void GotoScene_Blue()
    {
        SceneManager.LoadScene("Level_3");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
