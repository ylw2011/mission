using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class UI : MonoBehaviour
{
    GameObject textin, localin, netin;
    string textinstr;
    string dlp = "http://www.ylw.idv.tw/arvideo";

    // Start is called before the first frame update
    void Start()
    {
        textin = GameObject.Find("InputField");
        localin = GameObject.Find("Local");
        netin = GameObject.Find("Network");
        LoadData();
    }

    public void SaveData()
    {
        textinstr = textin.GetComponentInChildren<Text>().text;

        //local
        PlayerPrefs.SetString("InputStr", textinstr);

        //network
        StartCoroutine(NetworkSaveData());
    }

    IEnumerator NetworkSaveData()
    {
        UnityWebRequest uw = new UnityWebRequest();        
        WWWForm form = new WWWForm();

        form.AddField("InputStr", textinstr);
        UnityWebRequest req = UnityWebRequest.Post(dlp + "/NetTest.php", form);
        yield return req.SendWebRequest();

        if (req.isHttpError || req.isNetworkError)
            Debug.Log(req.error);
        else
            Debug.Log("Uploaded Log Successfully");
    }

    void LoadData()
    {
        localin.GetComponentInChildren<Text>().text = PlayerPrefs.GetString("InputStr");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
