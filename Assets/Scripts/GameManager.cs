using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //Singleton

    public bool isPaused;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy (gameObject);
            }
        }
        DontDestroyOnLoad (gameObject);
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
