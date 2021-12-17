using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    RectTransform canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;

    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("CanvasLab").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = 2;
    }

    void Update()
    {
         if(Input.GetKeyDown("w"))
        {
            transform.Translate(0f, speed, 0f);
        }
    }
}