using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
public void Update() {
    if (Input.GetKeyDown(KeyCode.Escape)) {
        Application.Quit();
    }
}
}
