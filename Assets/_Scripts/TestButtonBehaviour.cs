using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text SceneLable,Score,Lives;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        SceneLable.text = "TEST";
        Lives.rectTransform.anchoredPosition = new Vector3(370.0f, -105.0f, 0.0f);
        Score.rectTransform.anchoredPosition = new Vector3(-349.0f, -105.0f, 0.0f);
    }
}