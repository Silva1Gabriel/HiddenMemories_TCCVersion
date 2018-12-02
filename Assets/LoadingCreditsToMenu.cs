using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingCreditsToMenu : MonoBehaviour {
    public bool credits = false;
    void Update()
    {
        StartCoroutine(WaitForNewSceneLoad());
        credits = true;
        if (Input.GetKeyDown(KeyCode.Escape) && credits == true)
        {
            SceneManager.LoadScene("Attic");
            credits = false;
        }
    }

    private IEnumerator WaitForNewSceneLoad()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene("Attic");
    }
}
