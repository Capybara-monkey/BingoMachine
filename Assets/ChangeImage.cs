using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {
    public Sprite spriteAto;
    public Sprite image;
    public static int id;
    public static List<int> done = new List<int>();
    public string test;
    public static int len;
    public static bool quiz;


    public void changeSprite(){
        if (!quiz){
            quiz = true;
            System.Random r = new System.Random();
            id = r.Next(1,22);
            if (!done.Contains(id)){
                done.Add(id);
                len += 1;
            }
            else{
                for (int i=1; i<=21; i++){
                    if (!done.Contains(i)){
                        id = i;
                        done.Add(i);
                        len += 1;
                        break;
                    }
                }
            }
            for (int i=0; i<len; i++){
                if (i==0){
                    test = done[i].ToString() + ",";
                }
                else{
                    test += done[i].ToString() + ",";
                }
            }
            Debug.Log(test);
            Sprite image = Resources.Load<Sprite> ("quiz/quiz"+id.ToString());
            this.gameObject.GetComponent<Image> ().sprite = image;
        }
    }

    public static bool getQuiz(){
        return quiz;
    }

    public static int getId(){
        return id;
    }

    public static void setQuiz(bool tf){
        quiz = tf;
    }
}