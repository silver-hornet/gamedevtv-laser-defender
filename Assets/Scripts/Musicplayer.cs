using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour
{
    void Awake()
    {
        SetUpSingleton();
    }

    void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1) //GetType means its getting its own type, in this case the MusicPlayer
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
