using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    private PointManager scoreManager;
    private TenKillsTrophies tenK;
    private HundredKillsTrophies hundredk;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<PointManager>();
        GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
        tenK = cam.GetComponent<TenKillsTrophies>();

        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        hundredk = camera.GetComponent<HundredKillsTrophies>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
            scoreManager.UpdateScore(50);
            tenK.EnemyK();
            hundredk.EnemeyH();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
