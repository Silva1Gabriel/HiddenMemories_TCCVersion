using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    

    public void TerrainLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("OutDoor");
    }

    public void LevelHouse()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("NewGroundFloor");
        
    }
    public void BasementLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Basement");
    }
}
