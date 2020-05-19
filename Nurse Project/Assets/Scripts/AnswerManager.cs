using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerManager : MonoBehaviour
{
    private int correctCounter;
    private int incorrectCounter;

    public int GetCorrect(){
        return correctCounter;
    }
    public void Count(int num){
        if(num == 1)
            correctCounter++;
        else if(num == -1)
            incorrectCounter++;
        
        if((GameModeHolder.Instance.mode == GameMode.normal && correctCounter == 5) || (GameModeHolder.Instance.mode == GameMode.survival && num == -1)){
            if(GameModeHolder.Instance.mode == GameMode.normal)
                GameModeHolder.Instance.SetFeedback(incorrectCounter);
            else
                GameModeHolder.Instance.SetFeedback(correctCounter);
            SceneManager.LoadScene("Main Menu");
        }
    }
}
