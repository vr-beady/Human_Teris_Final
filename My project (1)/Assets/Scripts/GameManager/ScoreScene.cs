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
        gM.final_score = PlayerPrefs.GetInt("Score"); // 取值
        correct_scoreText.text = "成功次數: " + gM.final_score;
    }
}
