using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageControls : MonoBehaviour
{
    public void PressPlay()
    {
        SceneManager.LoadScene(3);
    }
}
