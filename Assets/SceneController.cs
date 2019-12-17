using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public void ButtonClicked () {
        SceneManager.LoadScene("Scenes/lottery_playing");
	}

	public void ToAns () {
	    if (ChangeImage.getQuiz()){
            SceneManager.LoadScene("Scenes/answer");
            ChangeImage.setQuiz(false);
        }
	}

	public void ToHome () {
	    if (OpenAnswer.getAnsDone()){
	        SceneManager.LoadScene("Scenes/lottery");
	        OpenAnswer.setAnsDone(false);
	    }
	}
}