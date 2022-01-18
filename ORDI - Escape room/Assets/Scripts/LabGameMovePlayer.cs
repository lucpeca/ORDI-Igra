using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabGameMovePlayer : MonoBehaviour
{
    //RectTransform canvas;
    //RectTransform button;
    Vector3 startingPosition;
    public float speed;


    private bool[] touched;
    private bool winCondition = true;

    void Start()
    {
        //button = gameObject.GetComponent<RectTransform>();
        //canvas = GameObject.Find("CanvasLab").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = 10f;
        touched = new bool[15];
    }

    private void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find("skripte").gameObject.GetComponent<LabGameMovePlayer>().enabled = false;

            GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y + speed, transform.position.z);
        }
        if (Input.GetKey("s"))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y - speed, transform.position.z);
        }
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(transform.position.x - speed,
                transform.position.y, transform.position.z);
        }
        if (Input.GetKey("d"))
        {
            transform.position = new Vector3(transform.position.x + speed,
                transform.position.y, transform.position.z);
        }
    }
    


    void OnTriggerEnter2D(Collider2D col)
    {

        switch (col.name)
        {
            case "Button (1)":
                touched[0] = true;
                Debug.Log(touched[0]);
                break;
            case "Button (2)":
                touched[1] = true;
                break;
            case "Button (3)":
                touched[2] = true;
                break;
            case "Button (4)":
                touched[3] = true;
                break;
            case "Button (6)":
                touched[5] = true;
                break;
            case "Button (7)":
                touched[6] = true;
                break;
            case "Button (9)":
                touched[8] = true;
                break;
            case "Button (12)":
                touched[11] = true;
                break;
            case "Button (14)":
                touched[13] = true;
                break;
            case "SuccesButton":
                checkForSuccess();
                break;
            default:
                winCondition = false;
                break;
        }
    }

    private void checkForSuccess()
    {
        if (touched[0] && touched[1] && touched[2] && touched[3] && touched[5] && touched[6] && touched[8] && touched[11] && touched[13] && winCondition)
        {
            Debug.Log("Ma bravo");
        }
        else
        {
            resetAll();
        }
    }

    private void resetAll()
    {
        for (int i = 0; i < touched.Length; i++)
        {
            touched[i] = false;
        }
        winCondition = true;
        this.gameObject.transform.position = startingPosition;

        Debug.Log("win con je " + winCondition);
        for (int i = 0; i < touched.Length; i++)
        { 
            Debug.Log(touched[i]);
        }
        
    }
}