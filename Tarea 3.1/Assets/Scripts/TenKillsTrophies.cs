using GameJolt.API.Objects;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenKillsTrophies : MonoBehaviour
{
    public int enemyKills;
   
    public void EnemyK()
    {
        enemyKills += 1;
        if (enemyKills == 10)
        {
            Trophies.Get(198175, (Trophy trophy) =>
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
