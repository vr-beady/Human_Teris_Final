using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class viewwall : MonoBehaviour
{
    public GameObject[] wall;
    private int nowWall;
    private float nextWallTime = 0f;
    private float preTime;
    public TextMeshProUGUI wall_name;

    void Start()
    {
        preTime = Time.time;
    }
    void Update()
    {
        if (Time.time - preTime > nextWallTime)
        {
            nowWall = Random.Range(0, 17);//ÀH¾÷Àð
            nextWallTime = Random.Range(6, 9);//6~9¬í¤@­ÓÀð
            Instantiate(wall[nowWall], new Vector3(0, 5, -40), wall[nowWall].transform.rotation);
            wall_name.text = wall[nowWall].name;
            preTime = Time.time;
        }
    }
}
