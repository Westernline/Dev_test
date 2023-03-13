using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameObject gameOverPanel;
    public GameObject Pause;
    public GameObject Play;
    public GameObject ShootGameOver;
    public GameObject Ulta;
    public GameObject UI;


    int Kill = 0;
    int health = DestroyPlayer.health;
    int Power = DestroyPlayer.Power;
    bool gameOver = false;
    

    public TextMeshProUGUI KillText;
    


    void Update ()
    {
        if (DestroyPlayer.Power == 100)
        {
            ShootGameOver.SetActive(true);
        }
        if (DestroyPlayer.Power != 100)
        {
            ShootGameOver.SetActive(false);
        }
        if (DestroyPlayer.health == 0)
        {
            GameOver();
        }
    }
    


    private void Awake()
    {
        instance = this;
    }

    public void InrementScore()
    {
        if (!gameOver)
        {
            Kill++;
            KillText.text = Kill.ToString();
            
        }
    }



    public void ShootBot ()
    {
        Ulta.SetActive(true);
        DestroyPlayer.Power -= 100;
        StartExampleCoroutine();
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1f);
        Ulta.SetActive(false);
    }
    public void StartExampleCoroutine()
    {
        StartCoroutine(ExampleCoroutine());
    }



    /*public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            print(lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }*/

    public void PauseGame ()
    {
        Time.timeScale = 0.0f;
        Pause.SetActive(false);
        Play.SetActive(true);
    }
    public void PlayGame ()
    {
        Time.timeScale = 1.0f;
        Play.SetActive(false);
        Pause.SetActive(true);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        UI.SetActive(false);
    }

    public void Restart()
    {
        DestroyPlayer.health = 100;
        DestroyPlayer.Power = 50;
        SceneManager.LoadScene(0);
        UI.SetActive(true);
        gameOverPanel.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
