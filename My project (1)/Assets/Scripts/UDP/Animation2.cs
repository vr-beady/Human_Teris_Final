using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation2 : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] Body;
    private List<string> animationData;
    private int counter = 0;
    private Vector3[] targetPositions; // 保存目標位置
    private float interpolationFactor = 0.2f; // 插值因子，控制平滑程度

    void Start()
    {
        animationData = new List<string>();
        // lines = System.IO.File.ReadAllLines("Assets/AnimationFile.txt").ToList();
        targetPositions = new Vector3[Body.Length]; // 初始化目標位置陣列
    }

    void Update()
    {
        string receivedData = udpReceive.data;
        if (receivedData.Length > 1)
        {
            receivedData = receivedData.Remove(0, 1);
            receivedData = receivedData.Remove(receivedData.Length - 1, 1);
        }

        string[] points = receivedData.Split(',');
        if (points.Length >= 99) // 檢查陣列長度是否足夠大
        {
            for (int i = 0; i < 33 && i < Body.Length; i++)
            {
                float x, y, z;
                if (float.TryParse(points[0 + (i * 3)], out x) && float.TryParse(points[1 + (i * 3)], out y) && float.TryParse(points[2 + (i * 3)], out z))
                {
                    x /= 100f;
                    y /= 100f;
                    z /= 300f;
                    Vector3 targetPosition = new Vector3(x, y, z);
                    targetPositions[i] = targetPosition; // 保存目標位置
                }
                else
                {
                    //print("Failed to parse float values for index \n");
                    //Debug.LogError("Failed to parse float values for index " + i);
                }
            }
        }
        else
        {
            //print("站遠一點\n");
            //Debug.LogError("Received data does not have enough points");
        }

        // 插值平滑過渡
        for (int i = 0; i < Body.Length; i++)
        {
            Vector3 currentPosition = Body[i].transform.localPosition;
            Vector3 targetPosition = targetPositions[i];
            Vector3 newPosition = Vector3.Lerp(currentPosition, targetPosition, interpolationFactor);
            Body[i].transform.localPosition = newPosition;
        }

        counter++;
        if (counter == points.Length)
            counter = 0;

        StartCoroutine(WaitForNextFrame());//等待一段時間
    }


    private IEnumerator WaitForNextFrame()
    {
        yield return new WaitForSeconds(0.01f); // 等待 0.03 秒
    }
}
