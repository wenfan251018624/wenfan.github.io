using UnityEngine;
using System.Collections;
using CubeC;

public class Tscreen : MonoBehaviour {
    //需要变动的开值
    float changValue = 0.5f;
    //运动时间
    float setTime = 7;
    void Update()
    {
        Flag.tfk += Time.deltaTime;
        if (!Flag.flag08)
        {
            //open action
            if (Flag.tfk <= setTime)
            {
                gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, Flag.tfk * changValue / setTime);
            }
            if (Flag.tfk >= setTime)
            {
                this.GetComponent<Tscreen>().enabled = false;
            }
        }
        else
        {
            if (Flag.tfk <= setTime)
                gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, changValue - Flag.tfk * changValue / setTime);
            if (Flag.tfk >= setTime)
            {
                this.GetComponent<Tscreen>().enabled = false;
            }
        }
    }
}
