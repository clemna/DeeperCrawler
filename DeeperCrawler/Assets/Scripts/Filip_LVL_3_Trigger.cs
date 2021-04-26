using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Filip_LVL_3_Trigger : MonoBehaviour
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
            SceneManager.LoadScene("LVL 4");
        }
    }

    public void RespawnPlayer()
    {
        transform.position = spawnPoint;
    }
}
