using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlappyBirdManager : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
