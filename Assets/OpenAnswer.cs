using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAnswer : MonoBehaviour {
    public Sprite image;

    public void openAns(){
            Sprite image = Resources.Load<Sprite> ("answer/ans"+ ChangeImage.getId().ToString());
            this.gameObject.GetComponent<Image> ().sprite = image;
    }
}
