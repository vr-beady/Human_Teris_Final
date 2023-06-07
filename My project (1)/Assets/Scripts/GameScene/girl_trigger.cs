using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_trigger : MonoBehaviour
{
    /*
    private string[] body = new string[13] { "Head",
        "Rshoulder", "Relbow", "Rhand",
        "Lshoulder", "Lelbow", "Lhand",
        "Rpelvis", "RKnee", "Rfoot",
        "Lpelvis", "Lknee", "Lfoot" };
    */

    private GameScene gM;

    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameScene>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gM.colliders.Contains(other.gameObject) && other.gameObject.tag == gameObject.tag)
        {
            gM.colliders.Add(other.gameObject);
            Debug.Log(other.gameObject.tag + "_touch");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        gM.colliders.Remove(other.gameObject);
    }
}
