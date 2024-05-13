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

    public void StartGame() // Todo: �Է� ���̰� 9�� �����Ǵ� ���� ����
    {
        Debug.Log("�Է� ����: " + inputName.text.Length);
        if (inputName.text.Length >= 2 && inputName.text.Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("�Է��� ���ڼ��� 2~10���� ���̿��� �մϴ�.");
        }
    }
}
