using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEscenarios : MonoBehaviour
{
    public GameObject MenuExt;


    public void hide() {
        MenuExt.SetActive(false);
    }

    public void show() {
        MenuExt.SetActive(true);
    }  

}
