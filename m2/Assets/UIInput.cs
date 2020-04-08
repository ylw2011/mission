using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIInput : MonoBehaviour
{
    public void buttonstart()
    {
        SceneManager.LoadScene(1);
    }

    public void buttonquit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
