using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject target;
    int delay=0;
    int enemynum = 10;

    // Start is called before the first frame update
    void Start()
    {        
        target = GameObject.Find("Foe");
        target.SetActive(false);  //先將複製標的物停止        
    }

    // Update is called once per frame
    void Update()
    {
        delay++;
        if (delay % Random.Range(10,30) == 0 && enemynum>0) 
        {
            GameObject newobj = Instantiate(target); //複製標的物            
            Vector3 nv=new Vector3(Random.Range(190, 210), 2, Random.Range(90, 110));
            newobj.name ="Smoke-"+delay.ToString();
            newobj.transform.parent = GameObject.Find("MainCamera").transform;
            newobj.transform.position = nv;
            newobj.SetActive(true);  //啟動標的物
            enemynum--;
        }
    }
}
