using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
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
        int xcount = Random.Range(5, 15);
        speed = xcount;
    }

    void Update()
    {
        if (transform.position.y < 165) {
            speed = -speed;
        }
        if (transform.position.y > 645)
        {
            speed = -speed;
        }
        transform.Translate(0f, speed, 0f);
        if (button.position.y < -button.rect.height)
            transform.position = new Vector3(startingPosition.x, canvas.rect.height + button.rect.height, startingPosition.z);
    }
}