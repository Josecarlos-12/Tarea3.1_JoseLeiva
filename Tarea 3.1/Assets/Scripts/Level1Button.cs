using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Button : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.SetInt("death", 0);
    }
}
