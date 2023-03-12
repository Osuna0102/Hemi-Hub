using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideV3 : MonoBehaviour
{
    public GameObject ourCube;
    public GameObject ourCube1;
    public GameObject ourCube2;



    public void hide3() {
        ourCube.SetActive(false);
        ourCube1.SetActive(false);
        ourCube2.SetActive(false);


    }

    public void show3() {
        ourCube.SetActive(true);
        ourCube1.SetActive(true);
        ourCube2.SetActive(true);

    }

    public void show1hide2() {
        ourCube.SetActive(true);
        ourCube1.SetActive(false);
        ourCube2.SetActive(false);

    }

}
