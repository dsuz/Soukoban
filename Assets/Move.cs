using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// オブジェクトを滑らかに動かす機能を提供する
/// </summary>
public class Move : MonoBehaviour
{
    /// <summary>移動までにかかる時間（秒）</summary>
    public float duration = 0.2f;
    /// <summary>移動を始めてから経過した時間（秒）</summary>
    float elapsedTime;
    Vector3 destination;
    Vector3 origin;

    void Start()
    {
        destination = transform.position;
        origin = destination;
    }

    void Update()
    {
        if (transform.position == destination)
        {
            return;
        }
        
        elapsedTime += Time.deltaTime;
        float timeRatio = elapsedTime / duration;
        
        //if (timeRatio > 1)
        //{
        //    timeRatio = 1;
        //}
        
        float easing = timeRatio;

        Vector3 currentPosition
            = Vector3.Lerp(origin, destination, easing);
        transform.position = currentPosition;
    }

    /// <summary>
    /// オブジェクトを滑らかに移動させる
    /// </summary>
    /// <param name="destination">目的地の座標</param>
    public void MoveTo(Vector3 destination)
    {
        elapsedTime = 0;
        origin = this.destination;
        // 移動中だった場合はキャンセルして目的にワープする
        transform.position = origin;
        this.destination = destination;
    }
}
