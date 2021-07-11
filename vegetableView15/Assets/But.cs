using UnityEngine;
using System.Collections;
using CubeC;
using UnityEngine.SceneManagement;

public class But : MonoBehaviour {
    public GameObject[] Findmen = new GameObject[4];
    GameObject go;
    void OnClick()
    {
        switch (gameObject.name)
        {
            case "Button01"://开启电扇旋转
                Flag.flag06 = true;
                break;
            case "Button02":
                Flag.flag06 = false;
                //关闭电扇旋转
                break;
            case "Button03":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("fengshanPanel").gameObject;
                go.SetActive(false);
                Flag.flag04 = false;//关闭电扇显示界面
                break;
            case "Button04":
                go = GameObject.Find("chufa");
                go = go.transform.FindChild("springLa").gameObject;
                go.SetActive(true);//开启辣椒水管
                break;
            case "Button05":
                go = GameObject.Find("chufa");
                go = go.transform.FindChild("springLa").gameObject;
                go.SetActive(false);//关闭辣椒水管
                break;
            case "Button06":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("shuiguanPanelLa").gameObject;
                go.SetActive(false);
                Flag.flag03 = false;//关闭辣椒水管显示界面
                break;
            case "Button07"://开启通风口
                {
                    Flag.flag08 = true;
                    Flag.tfk = 0.0f;
                    Findmen[0].gameObject.GetComponent<Tscreen>().enabled = true;
                    Flag.tfk = 0.0f;
                    Findmen[1].gameObject.GetComponent<Tscreen>().enabled = true;
                    Flag.tfk = 0.0f;
                    Findmen[2].gameObject.GetComponent<Tscreen>().enabled = true;
                    Flag.tfk = 0.0f;
                    Findmen[3].gameObject.GetComponent<Tscreen>().enabled = true;
                }
                break;
            case "Button08"://关闭通风口
                {
                    Flag.flag08 = false;
                    Flag.tfk = 0.0f;
                    Findmen[0].gameObject.GetComponent<Tscreen>().enabled = true;
                    Flag.tfk = 0.0f;
                    Findmen[1].gameObject.GetComponent<Tscreen>().enabled = true;
                    Flag.tfk = 0.0f;
                    Findmen[2].gameObject.GetComponent<Tscreen>().enabled = true;
                    Flag.tfk = 0.0f;
                    Findmen[3].gameObject.GetComponent<Tscreen>().enabled = true;
                }
                break;
            case "Button09":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("tfkPanel").gameObject;
                go.SetActive(false);
                Flag.flag05 = false;//关闭通风口显示界面
                break;
            case "Button10"://开启胡萝卜购买
                break;
            case "Button11":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("carrotPanel").gameObject;
                go.SetActive(false);
                Flag.flag01 = false;//关闭胡萝卜显示界面
                break;
            case "Button12":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("carrotPanel").gameObject;
                go.SetActive(false);
                Flag.flag01 = false;//关闭胡萝卜显示界面
                break;
            case "Button13"://开启辣椒购买
                break;
            case "Button14":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("lajiaoPanel").gameObject;
                go.SetActive(false);
                Flag.flag02 = false;//关闭辣椒显示界面
                break;
            case "Button15":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("lajiaoPanel").gameObject;
                go.SetActive(false);
                Flag.flag02 = false;//关闭辣椒显示界面
                break;
            case "Button16":
                go = GameObject.Find("chufa");
                go = go.transform.FindChild("springCar").gameObject;
                go.SetActive(true);//开启胡萝卜水管
                break;
            case "Button17":
                go = GameObject.Find("chufa");
                go = go.transform.FindChild("springCar").gameObject;
                go.SetActive(false);//关闭胡萝卜水管
                break;
            case "Button18":
                go = GameObject.Find("UI Root");
                go = go.transform.FindChild("shuiguanPanelCar").gameObject;
                go.SetActive(false);
                Flag.flag09 = false;//关闭胡萝卜水管显示界面
                break;
            case "Button19":
                SceneManager.LoadScene("Land");
                break;
        }
    }
}
