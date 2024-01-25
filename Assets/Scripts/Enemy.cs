using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int life = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        death();
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            life--;
        }
    }
    public void death() 
    {
        if(life < 0)
        {
            Destroy(gameObject);
        }
    }

}
