using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private ChaineManager mouseManager;

    private void Awake()
    {
        mouseManager = GetComponent<ChaineManager>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mouseManager.CancelDrag();
        }
    }
}
