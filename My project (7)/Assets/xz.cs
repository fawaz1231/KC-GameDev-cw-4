using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xz : MonoBehaviour
{
    int health =100;
    int damagedHealth;
    // Start is called before the first frame update
    void Start()
    {
        damagedHealth = Damage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int Damage()
    {
       return health - 20;
    }
}
