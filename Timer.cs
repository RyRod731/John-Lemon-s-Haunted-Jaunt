using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float countdown = 60;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown > 0)
        {
            countdown -= Time.deltaTime;
        }
        double b = System.Math.Round(countdown, 2);
        text.text = b.ToString();
    }
}
