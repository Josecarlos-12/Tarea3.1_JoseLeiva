using GameJolt.API.Objects;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoseTrophies : MonoBehaviour
{
    public enum Levels { start, level1, level2, level3, credits }
    public Levels levels;
    // Start is called before the first frame update
    void Start()
    {
        switch (levels)
        {
            case Levels.start:
                Trophies.Get(198169, (Trophy trophy) =>
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
                break;
            case Levels.level1:
                Trophies.Get(198171, (Trophy trophy) =>
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
                break;
            case Levels.level2:
                Trophies.Get(198172, (Trophy trophy) =>
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
                break;
            case Levels.level3:
                Trophies.Get(198173, (Trophy trophy) =>
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
                break;
            case Levels credits:
                Trophies.Get(198174, (Trophy trophy) =>
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
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
