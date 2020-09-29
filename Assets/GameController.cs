using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class GameController : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

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
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -105f);
                break;
            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -105f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-376.0f, -105f);
                break;
            case DeviceOrientation.Portrait:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -185f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349.0f, -185f);
                break;
            case DeviceOrientation.Unknown:
                break;
        }
      
    }
}
