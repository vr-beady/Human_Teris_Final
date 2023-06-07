using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoadScene : MonoBehaviour
{
    private GameManager gM;
    void Start()
    {
        gM = transform.GetComponent<GameManager>();
        PlayerPrefs.SetInt("Score", 0);
        gM.ToStart();
    }
}
