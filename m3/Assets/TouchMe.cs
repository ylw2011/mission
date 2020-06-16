using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMe : MonoBehaviour
{
    GameObject p1;
    GameObject chr;
    UserUI uui;

    // Start is called before the first frame update
    void Start()
    {
        p1=GameObject.Find("Smoke-"+this.name);
        p1.SetActive(false);

        chr = GameObject.Find("RigidBodyFPSController");
        uui=chr.GetComponent<UserUI>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("enter");         
    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("stay");
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("exit");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name== "RigidBodyFPSController") //0617
        {
            Debug.Log("Enter");
            p1.SetActive(true);
            uui.SetScore(1);
            uui.SetLife(1);
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }

}
