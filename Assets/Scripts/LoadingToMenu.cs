using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    void Update()
    {
        StartCoroutine(WaitForNewSceneLoad());
    }

    private IEnumerator WaitForNewSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Attic");
    }
}

