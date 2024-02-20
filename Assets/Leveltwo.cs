using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leveltwo : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LoadLevelLater());
    }

     private IEnumerator LoadLevelLater()
    {
        yield return new WaitForSeconds(10.0f);
        SceneManager.LoadScene("Level 2");
    }
}
