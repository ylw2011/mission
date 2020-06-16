using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyAI : MonoBehaviour
{
    GameObject chr;
    UserUI uui;

    // Start is called before the first frame update
    void Start()
    {
        chr = GameObject.Find("RigidBodyFPSController");
        uui = chr.GetComponent<UserUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(chr.transform.position, transform.position) < 1.0f) uui.SetLife(-1);
    }
}
