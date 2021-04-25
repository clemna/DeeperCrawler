using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instace;

    private void Awake()
    {
        instace = this;
    }

    #endregion

    public GameObject player;
}
