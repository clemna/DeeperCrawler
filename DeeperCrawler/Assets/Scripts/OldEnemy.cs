using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldEnemy : MonoBehaviour
{

    private OldHealth health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<OldHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int dmg)
    {
        health.TakeDamage(dmg);
    }
}
