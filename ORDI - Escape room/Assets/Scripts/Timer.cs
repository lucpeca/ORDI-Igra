using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float initialTime;
    public GameObject Num;
    private bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        Num = this.gameObject.transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.GetKeyDown("x")) {
            if (started == false) { 
            initialTime = Time.time; }
            started = true;
        }
        if (started == true)
        {
            float TimeTaken = Time.time - initialTime;
            Num.GetComponent<Text>().text = TimeTaken.ToString("f2");
        }
    }
}
