using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show1hide3 : MonoBehaviour
{
    public GameObject ourIdle;
    public GameObject ourCube;
    public GameObject ourCube1;
    public GameObject ourCube2;

    public void show1_hide3() {
        ourIdle.SetActive(false);
        ourCube.SetActive(true);
        ourCube1.SetActive(false);
        ourCube2.SetActive(false);

    }
}
