using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    RectTransform canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;

    public static bool won = false;
    public bool winonce = false;

    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("CanvasLab").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = 3f;
    }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    private void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            GameObject.Find("Dodge-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasLab").gameObject.SetActive(false);
            gameObject.GetComponent<MovePlayer>().enabled = false;

        }
    }
<<<<<<< Updated upstream

    void FixedUpdate()
    {

=======
    void FixedUpdate()
    {
>>>>>>> Stashed changes
        if (won == true && winonce == false) {
            winonce = true;
            GameObject.Find("Dodge-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.green;
            GameObject.Find("First Person Player").gameObject.GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("First Person Player").gameObject.transform.GetChild(1)
                .GetComponent<MouseLook>().enabled = true;
            GameObject.Find("CanvasLab").gameObject.SetActive(false);
            gameObject.GetComponent<MovePlayer>().enabled = false;

        }

         if(Input.GetKey("w"))
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
                transform.position.y,  transform.position.z);
        }
        if (Input.GetKey("d"))
        {
            transform.position = new Vector3(transform.position.x + speed,
                transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Win")
        {
            won = true;
        }
        if (col.name.Contains("Button") || col.name.Contains("Wal")) {
            transform.position = startingPosition;
        }
       
    }
}