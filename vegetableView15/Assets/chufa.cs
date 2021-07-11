using UnityEngine;
using System.Collections;
using CubeC;
using UnityEngine;
using System.Collections;
using CubeC;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class chufa : MonoBehaviour
{
    public GameObject[] Feng = new GameObject[6];
    string[] Name = new string[6];
    // Use this for initialization
    void Start()
    {
        DynamicGI.UpdateEnvironment();
        Name[0] = "Carrot01";
        Name[1] = "lajiao01";
        Name[2] = "shuiguanLa";
        Name[3] = "fengshan01";
        Name[4] = "tfk01";
        Name[5] = "shuiguanCar";
    }
    // Update is called once per frame
    void Update()
    {
        GameObject go;
        if (Flag.flag06)
        {
            Feng[0].transform.Rotate(new Vector3(1, 0, 0), 4);
            Feng[1].transform.Rotate(new Vector3(1, 0, 0), 4);
            Feng[2].transform.Rotate(new Vector3(1, 0, 0), 4);
            Feng[3].transform.Rotate(new Vector3(1, 0, 0), 4);
            Feng[4].transform.Rotate(new Vector3(0, 1, 0), 4);
            Feng[5].transform.Rotate(new Vector3(0, 1, 0), 4);
        }
        Flag.flagF = Flag.flag01 || Flag.flag02 || Flag.flag03 || Flag.flag04 || Flag.flag05||Flag.flag09;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {//点击检测
                string Tex = hit.collider.gameObject.name;
                if (Flag.flagF)//界面冲突
                { }
                else
                {
                    if (Tex == Name[0])
                    {//胡萝卜
                        go = GameObject.Find("UI Root");
                        go = go.transform.FindChild("carrotPanel").gameObject;
                        go.SetActive(true);
                        Flag.flag01 = true;
                    }
                    if (Tex == Name[1])
                    {//辣椒
                        go = GameObject.Find("UI Root");
                        go = go.transform.FindChild("lajiaoPanel").gameObject;
                        go.SetActive(true);
                        Flag.flag02 = true;
                    }
                    if (Tex == Name[2])
                    {//水管
                        go = GameObject.Find("UI Root");
                        go = go.transform.FindChild("shuiguanPanelLa").gameObject;
                        go.SetActive(true);
                        Flag.flag03 = true;
                    }

                    if (Tex == Name[5])
                    {//水管
                        go = GameObject.Find("UI Root");
                        go = go.transform.FindChild("shuiguanPanelCar").gameObject;
                        go.SetActive(true);
                        Flag.flag09 = true;
                    }
                    if (Tex == Name[3])
                    {//风扇
                        go = GameObject.Find("UI Root");
                        go = go.transform.FindChild("fengshanPanel").gameObject;
                        go.SetActive(true);
                        Flag.flag04 = true;
                    }
                    if (Tex == Name[4])
                    {//通风口
                        go = GameObject.Find("UI Root");
                        go = go.transform.FindChild("tfkPanel").gameObject;
                        go.SetActive(true);
                        Flag.flag05 = true;
                    }
                }
            }
        }
    }
    //if (Flag.flag08)
    //{
    //    NGUITools.SetActive(ST[5], true);
    //    //开启通风口
    //}
    //else
    //{
    //    NGUITools.SetActive(ST[5], false);
    //}
    //if (Flag.flag09)
    //{
    //    NGUITools.SetActive(ST[5], true);
    //    //辣椒购买
    //}
    //else
    //{
    //    NGUITools.SetActive(ST[5], false);
    //}
    //if (Flag.flag10)
    //{
    //    NGUITools.SetActive(ST[5], true);
    //    //胡萝卜购买
    //}
    //else
    //{
    //    NGUITools.SetActive(ST[5], false);
    //}
    //if (Flag.flag11)
    //{
    //    NGUITools.SetActive(ST[5], true);
    //    //进入大棚，开门
    //}
    //else
    //{
    //    NGUITools.SetActive(ST[5], false);
    //}

}