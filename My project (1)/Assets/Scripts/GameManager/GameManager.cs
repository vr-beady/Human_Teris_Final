using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //　場景管理員

public class GameManager : MonoBehaviour
{
    //這邊放不同場景通用的值
    public int final_score;  // 最終分數

    //場景切換
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
        PlayerPrefs.SetInt("Score", final_score); // 去下一個場景之前先存final_score
        SceneManager.LoadScene("Score");
    }
}
