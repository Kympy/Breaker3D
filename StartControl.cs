using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartControl : MonoBehaviour
{
    public bool mute = false;

    private AudioSource bgm;

    private void Start()
    {
        bgm = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MuteGame()
    {
        if (mute == false)
        {
            bgm.Stop();
            mute = true;

            GetComponentInChildren<Text>().text = "MUTE*";
        }
        else
        {
            bgm.Play();
            mute = false;
            GetComponentInChildren<Text>().text = "MUTE";
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LevelEasy()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelNormal()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelHard()
    {
        SceneManager.LoadScene(1);
    }
}
