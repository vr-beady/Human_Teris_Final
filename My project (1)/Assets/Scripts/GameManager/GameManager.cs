using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //�@�����޲z��

public class GameManager : MonoBehaviour
{
    //�o��񤣦P�����q�Ϊ���
    public int final_score;  // �̲פ���

    //��������
    public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void ToScore()
    {
        PlayerPrefs.SetInt("Score", final_score); // �h�U�@�ӳ������e���sfinal_score
        SceneManager.LoadScene("Score");
    }
}
