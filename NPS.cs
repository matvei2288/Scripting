using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    int health = 10;
    int level = 1000;
    health += level;
    
    // Start is called before the first frame update
    void Start()
    {
       print("здоровье:" + health); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
