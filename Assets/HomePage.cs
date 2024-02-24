using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("StageOne");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("StageTwo");
    }
}
