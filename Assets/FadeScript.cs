﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {
    float alfa = 0;
    float speed = 0.1f;
    float red, green, blue;

    void Start () {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    void Update () {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
        alfa += speed;
    }
}