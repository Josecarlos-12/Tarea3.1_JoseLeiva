using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLifes : MonoBehaviour
{
    public int lifes = 3;
    public Image[] lifesUI;
    public GameObject losePanel;
    public int dieCounter;
    public DieTrophie dieTrophie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag=="Enemy")
        {
            Destroy(collision.collider.gameObject);
            lifes -= 1;
            for (int i = 0; i<lifesUI.Length;i++)
            {
                if (i < lifes)
                {
                    lifesUI[i].enabled = true;
                }
                else
                {
                    lifesUI[i].enabled = false;
                }
            }
            if (lifes <= 0)
            {
                losePanel.SetActive(true);
                dieTrophie.Deads();
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBomb")
        {
            Destroy(collision.gameObject);
            lifes -= 1;
            for (int i = 0; i < lifesUI.Length; i++)
            {
                if (i < lifes)
                {
                    lifesUI[i].enabled = true;
                }
                else
                {
                    lifesUI[i].enabled = false;
                }
            }
            if (lifes <= 0)
            {
                losePanel.SetActive(true);
                dieTrophie.Deads();
                Destroy(gameObject);
                
            }
        }
    }
}
