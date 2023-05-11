using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneManager : MonoBehaviour
{
    public void LoadLevel(string p_levelToLoad)
    {
        SceneManager.LoadScene(p_levelToLoad);
    }
}
