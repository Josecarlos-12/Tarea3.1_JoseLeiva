using GameJolt.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool signedID) =>
        {
            if (signedID)
            {
                SceneManager.LoadScene("Start");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
