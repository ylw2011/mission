using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserUI : MonoBehaviour
{
    GameObject uui;
    GameObject hpi;    
    GameObject[] hps;
    GameObject gameover;
    Text[] ts;
    int score=0;
    int life = 3;
    int maxlife = 10;

    // Start is called before the first frame update
    void Start()
    {
        gameover = GameObject.Find("GameOver");
        gameover.SetActive(false);

        uui = GameObject.Find("Canvas");
        ts=uui.GetComponentsInChildren<Text>();
        ts[1].text = "V"+Application.version;

        hps = new GameObject[maxlife]; //0617
        hpi = GameObject.Find("Hp");
        hpi.SetActive(false);
        for (int i=0;i< maxlife; i++)
        {
            hps[i]= Instantiate(hpi);            
            hps[i].name = "Hp" + (i + 1).ToString();            
            hps[i].transform.SetParent(uui.transform);
            if(i<life) hps[i].SetActive(true);
            Vector3 nv = new Vector3(i * 40, 363, 0);
            hps[i].transform.position = nv;
        }
    }

    public void SetScore(int s)
    {
        if(s<5) score = score + s;
        ts[0].text = score.ToString();
    }

    public void SetLife(int s) //0617
    {
        life += s;
        if (life<=0)
        {
            life = 0;
            //game over
            gameover.SetActive(true);
        }
        for (int i = 0; i < maxlife; i++) //0617
        {
            if (i < life) hps[i].SetActive(true); else hps[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
                
    }
}
