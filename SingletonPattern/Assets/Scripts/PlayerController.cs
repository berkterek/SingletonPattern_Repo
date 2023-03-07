using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        SaveLoadManager saveLoadManager = SaveLoadManager.SingletonCreate();
    }
}