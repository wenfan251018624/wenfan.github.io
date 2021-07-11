using UnityEngine;
using System.Collections;
using CubeC;
public class SScreen : MonoBehaviour {
    //需要变动的开值
    float changValue = 0.5f;
    //运动时间
    float setTime = 3;
    void Update()
    {
        Flag.tempTime += Time.deltaTime;
        if (!Flag.flag07)
        {
            //open action

            if (Flag.tempTime <= setTime)
            {
                gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, Flag.tempTime * changValue / setTime);
            }
            if (Flag.tempTime >= setTime)
            {
                this.GetComponent<SScreen>().enabled = false;
            }
        }
        else
        {
            if (Flag.tempTime <= setTime)
                gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, changValue - Flag.tempTime * changValue / setTime);
            if (Flag.tempTime >= setTime)
            {
                this.GetComponent<SScreen>().enabled = false;
            }
        }
    }
}
