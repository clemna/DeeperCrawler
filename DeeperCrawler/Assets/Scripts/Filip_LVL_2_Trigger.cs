using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Filip_LVL_2_Trigger : MonoBehaviour
{
    public Vector3 spawnPoint;

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Water")
        {
            RespawnPlayer();
        }

        if (coll.tag == "NextLevel")
        {
            SceneManager.LoadScene("LVL 3");
        }
    }

    public void RespawnPlayer()
    {
        transform.position = spawnPoint;
    }
}
