using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManageScreen : MonoBehaviour
{
    public static ManageScreen Instance;
    public int movementTarget = 21;
    public GameObject StartScreen;
    public GameObject TryAgainScreen;
    public GameObject NextLevelScreen;
    public GameObject pauseScreen;
    public Text movementText;
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        movementText.text = movementTarget.ToString();
    }
    public void LoseScreen()
    {

        TryAgainScreen.SetActive(true);

    }
    public void WinScreen()
    {
        NextLevelScreen.SetActive(true);
    }
    public void CloseStartScreen()
    {
        StartScreen.SetActive(false);
    }
    public void PauseScreen()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosePauseScreen()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
