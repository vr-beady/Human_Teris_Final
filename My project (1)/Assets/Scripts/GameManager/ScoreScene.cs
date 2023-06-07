using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScene : MonoBehaviour
{
    private GameManager gM;
    public TextMeshProUGUI correct_scoreText;
    void Start()
    {
        gM = transform.GetComponent<GameManager>();
        gM.final_score = PlayerPrefs.GetInt("Score"); // ����
        correct_scoreText.text = "���\����: " + gM.final_score;
    }
}
