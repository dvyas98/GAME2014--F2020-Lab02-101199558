using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class GameController : MonoBehaviour
{
   public TMP_Text Score,Lives;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                Lives.rectTransform.anchoredPosition = new Vector3(370.0f, -105.0f, 0.0f);
                Score.rectTransform.anchoredPosition = new Vector3(-349.0f, -105.0f, 0.0f);
                //SceneLable.text= "Left";
                break;
            case DeviceOrientation.LandscapeRight:
                Lives.rectTransform.anchoredPosition = new Vector3(370.0f, -105.0f, 0.0f);
                Score.rectTransform.anchoredPosition = new Vector3(-349.0f, -105.0f, 0.0f);
                //SceneLable.text = "Right";
                break;
            case DeviceOrientation.Portrait:
               // SceneLable.text = "Portrait";
                break;
            case DeviceOrientation.Unknown:
                Debug.Log("Unknown Orientation");
                break;
        }
    }
}

