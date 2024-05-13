using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    public Text text;
    public void StartGame()
    {
        Debug.Log("입력 길이: " + text.text.Length);
        if (text.text.Length >=2 && text.text.Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("입력한 글자수가 2~10글자 사이여야 합니다.");
        }
    }
}
