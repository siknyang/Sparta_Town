using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    public Text text;
    public Text inputName;

    public void StartGame() // Todo: 입력 길이가 9로 고정되는 버그 수정
    {
        Debug.Log("입력 길이: " + inputName.text.Length);
        if (inputName.text.Length >= 2 && inputName.text.Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("입력한 글자수가 2~10글자 사이여야 합니다.");
        }
    }
}
