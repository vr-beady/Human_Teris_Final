using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    private float speed = 8.0f;
    private GameScene gM;
    private bool fin = false;

    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameScene>();
    }
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(!fin && transform.position.z > -15)
        {
            if (!gM.getPoint)
            {
                gM.UpdateScore();
            }
            if (gM.getPoint)
            {
                fin = true;
                gM.getPoint = false;
            }
        }
        if (!fin && transform.position.z > 0 && gM.colliders.Count == 0)
        {
            if (!gM.getPoint)
            {
                gM.count_Life();
            }
            fin = true;
            gM.getPoint = false;
        }
        if(transform.position.z > 10)
        {
            Destroy(gameObject);
        }
    }
}
