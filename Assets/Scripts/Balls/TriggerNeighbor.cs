using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNeighbor : MonoBehaviour
{
    public List<GameObject> AllTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.GetComponent<TriggerNeighbor>() != null && !AllTrigger.Contains(collision.gameObject))
        {
           // print("Collision avec : " + collision.name);
            AllTrigger.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null && collision.GetComponent<TriggerNeighbor>() != null && AllTrigger.Contains(collision.gameObject))
        {
            //print("Exit avec : " + collision.name);
            AllTrigger.Remove(collision.gameObject);
        }
    }
}
