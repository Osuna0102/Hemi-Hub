using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideV2 : MonoBehaviour
{
    public GameObject ourCube;
    public GameObject ourCube1;


    public void hide2() {
        ourCube.SetActive(false);
        ourCube1.SetActive(false);

    }

    public void show2() {
        ourCube.SetActive(true);
        ourCube1.SetActive(true);

    }  

}
