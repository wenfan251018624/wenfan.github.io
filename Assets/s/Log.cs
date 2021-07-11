using UnityEngine;
using System.Collections;
using CubeC;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class Log : MonoBehaviour
{
    GameObject Findme;
    Text userNum;
    Text userPsw;
    // Use this for initialization
    void Start()
    {
        Findme = GameObject.Find("name/Label");
        userNum = Findme.GetComponent<Text>();
        Findme = GameObject.Find("pass/Label");
        userPsw = Findme.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnClick()
    {
        switch (gameObject.name)
        {
            case "In":
                    Findme = GameObject.Find("Panel");
                    Findme = Findme.transform.FindChild("Show").gameObject;
                    Findme.SetActive(true);
                //Application.LoadLevel("场景名");
                //Debug.Log("jinru1");
                //Application.LoadLevel("Untitled");
                StartCoroutine(Load());
                //SceneManager.LoadScene("Untitled");
                break;
            case "Out":
                Application.Quit();
                //
                break;
        }
    }
    IEnumerator Load()
    {

        AsyncOperation op = SceneManager.LoadSceneAsync("Untitled");
        yield return new WaitForEndOfFrame();
        op.allowSceneActivation = true;

    }
}

