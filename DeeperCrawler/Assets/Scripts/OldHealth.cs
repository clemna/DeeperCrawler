using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldHealth : MonoBehaviour
{
    public int health = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        print("print");
        Destroy(this.gameObject);
    }
}
