using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtTimer;
    [SerializeField] private int beginTime;
    float timer = 0;

    private void Awake()
    {
        Begin();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        SetTime(timer);
    }
    void Begin()
    {
        timer = beginTime;
        SetTime(timer);
    }

    void SetTime(float time)
    {
        txtTimer.text = time.ToString("0.");
    }
}
