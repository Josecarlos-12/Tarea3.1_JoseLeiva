using GameJolt.API.Objects;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HundredKillsTrophies : MonoBehaviour
{
    public int enemyH;

    private void Start()
    {
        enemyH = PlayerPrefs.GetInt("Deads");
    }
    public void EnemeyH()
    {
        enemyH += 1;
        PlayerPrefs.SetInt("Deads", enemyH);
        if (enemyH == 100)
        {
            Trophies.Get(198176, (Trophy trophy) =>
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
