using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showhideObject : MonoBehaviour
{
    public GameObject ourCube;

    public void hide1() {
        ourCube.SetActive(false);
    }

    public void show1() {
        ourCube.SetActive(true);
    }  

}
