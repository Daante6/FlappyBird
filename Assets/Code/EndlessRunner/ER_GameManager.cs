using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ER_GameManager : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene("EndlessRunner");
    }
}
