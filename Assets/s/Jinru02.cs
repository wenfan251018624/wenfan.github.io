using UnityEngine;
using System.Collections;
using CubeC;
using UnityEngine.SceneManagement;

public class Jinru02 : MonoBehaviour
{

    public GameObject Findmen;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "First Person Controller")
        {
            Flag.flag07 = true;
            Flag.tempTime = 0.0f;
            Findmen.gameObject.GetComponent<SScreen>().enabled = true;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.name == "First Person Controller")
        {
            Flag.flag07 = false;
            Flag.tempTime = 0.0f;
            Findmen.gameObject.GetComponent<SScreen>().enabled = true;
        }
    }
}
