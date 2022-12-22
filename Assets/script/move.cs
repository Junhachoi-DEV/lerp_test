using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Transform start_pos;   
    public Transform end_pos;

    public float lerp_time = 0.5f;
    float cur_time = 0f;

    void Start()
    {
        this.transform.position = start_pos.position;
    }


    void Update()
    {
        cur_time += Time.deltaTime;

        if(cur_time>= lerp_time)
        {
            cur_time = lerp_time;
        }

        this.transform.position = Vector3.Lerp(start_pos.position, end_pos.position, cur_time /lerp_time);
    }
}
