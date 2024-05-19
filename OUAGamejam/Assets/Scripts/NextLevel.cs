using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevel;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
