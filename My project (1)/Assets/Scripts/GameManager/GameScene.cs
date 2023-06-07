using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScene : MonoBehaviour
{
    private GameManager gM;
    private UDPReceive udpR;
    public TextMeshProUGUI correct_scoreText;

    private int score = 0;    // �C�����涡����
    private int life = 5;  // �ͩR��
    public GameObject[] lifes;//�R��

    public List<GameObject> colliders = new List<GameObject>();
    public bool getPoint = false;

    void Start()
    {
        gM = transform.GetComponent<GameManager>();
        udpR = transform.GetComponent<UDPReceive>();
        correct_scoreText.text = "���\����: 0";
    }
    public void UpdateScore()
    {
        //Debug.Log(score);
        if (colliders.Count >= 10)
        {
            getPoint = true;
            score++;
            gM.final_score = score;
        }

        correct_scoreText.text = "���\����: " + score;
    }
    public void count_Life()
    {
        Destroy(lifes[--life]);
        if (life == 0)
        {
            udpR.UDPClose();
            gM.ToScore();
        }
    }
}
