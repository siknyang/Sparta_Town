using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterName : MonoBehaviour
{
    public Text inputName;

    private void Start()
    {
        inputName.text = GameManager.Instance.GetName();
    }
}
