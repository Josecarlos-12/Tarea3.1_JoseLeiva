using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerEnemys : MonoBehaviour
{
    public GameObject box;
    public GameObject enemyContainer;
    public float time;
    public float maxTime;
    public int quantity;
    public float timeNext;
    public float maxTimeN;
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
        NextLevel();
    }

    public void Spawner()
    {
        time += Time.deltaTime;
        if (time > maxTime)
        {
            time = 0;
            Instantiate(enemyContainer,transform.position,Quaternion.identity);
        }
    }

    public void NextLevel()
    {
        timeNext += Time.deltaTime;
        if (timeNext > maxTimeN)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
