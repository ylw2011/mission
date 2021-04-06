using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello2 : MonoBehaviour
{
    int x;
    public int Number;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {        
        if(x<10) x = x + 1;
    }
}
