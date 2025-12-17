using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] GameObject FadeOut;
    public void StartGame()
    {
        StartCoroutine(StartButton());
    }

    IEnumerator StartButton()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
