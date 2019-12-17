using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAnswer : MonoBehaviour {
    public Sprite image;
    public static bool ans_done = false;

    public void openAns(){
            Sprite image = Resources.Load<Sprite> ("answer/ans"+ ChangeImage.getId().ToString());
            this.gameObject.GetComponent<Image> ().sprite = image;
            ans_done = true;
    }

    public static bool getAnsDone(){
        return ans_done;
    }

    public static void setAnsDone(bool tf){
        ans_done = tf;
    }
}
