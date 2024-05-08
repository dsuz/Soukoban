using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int[] map;

    void Start()
    {
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        string debugText = "";

        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }

        Debug.Log(debugText);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("->");
        }
    }
}
