using GameJolt.API.Objects;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrophie : MonoBehaviour
{
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = PlayerPrefs.GetInt("death");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deads()
    {
        counter += 1;
        PlayerPrefs.SetInt("death",counter);
        if (counter == 10) 
        {
            Trophies.Get(198170, (Trophy trophy) =>
            {
                if (trophy != null)
                {
                    Trophies.TryUnlock(trophy, (TryUnlockResult result) =>
                    {
                        switch (result)
                        {
                            case TryUnlockResult.Unlocked:
                                Debug.Log("Desbloqueado con éxito");
                                break;
                            case TryUnlockResult.AlreadyUnlocked:
                                Debug.Log("Ya esta desbloqueado");
                                break;
                            case TryUnlockResult.Failure:
                                Debug.Log("Falló");
                                break;
                        }
                    });
                }
            });
        }
    }
}
