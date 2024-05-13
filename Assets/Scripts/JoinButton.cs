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
        Debug.Log("�Է� ����: " + text.text.Length);
        if (text.text.Length >=2 && text.text.Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("�Է��� ���ڼ��� 2~10���� ���̿��� �մϴ�.");
        }
    }
}
