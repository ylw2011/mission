using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIInput : MonoBehaviour
{
    Text[] mes;

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
        if (Application.platform == RuntimePlatform.WindowsEditor) Debug.Log("開發中");

        mes = GameObject.Find("Canvas").GetComponentsInChildren<Text>();

        string[] text = System.IO.File.ReadAllLines("Assets/tw.txt");
        for (int i = 0; i < text.Length; i++) mes[i].text=text[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
