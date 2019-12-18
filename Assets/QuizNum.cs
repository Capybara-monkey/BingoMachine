using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizNum : MonoBehaviour
{
    private Text quiz_num;

    public void display(){
        this.quiz_num = this.GetComponent<Text>();
        this.quiz_num.text = "第 " + ChangeImage.getLen().ToString() + "問";
    }
}
