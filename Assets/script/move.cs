using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Transform start_pos;   
    public Transform end_pos;
    void Start()
    {
        this.transform.position = start_pos.position;
    }

    
    void Update()
    {
        this.transform.position = Vector3.Lerp(start_pos.position, end_pos.position, 10 * Time.deltaTime);
    }
}
