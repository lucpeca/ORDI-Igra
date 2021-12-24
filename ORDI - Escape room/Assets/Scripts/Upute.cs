using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upute : MonoBehaviour
{
    // Start is called before the first frame update
    private bool on = true;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(on = true && Input.GetKeyDown("x")) {
            on = false;
            GameObject.Find("UputeCanvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);

        };
    }


}
