using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainedBall : MonoBehaviour
{
    [SerializeField] private ChaineManager mouseManager;
    public void OnMouseEnter()
    {
        mouseManager.LastEnter(this.name);
       // print("Enter : " + this.name);
    }
    public void OnMouseDrag()
    {
        mouseManager.LastDrag(this.name);
        print("Drag : " + this.name);
    }
}
