using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameStarter : MonoBehaviour
{
    public Canvas Canvas1;
    public Canvas Canvas2;
    public Canvas Canvas3;
    public Canvas InfoCanvas;
    public GameObject Minigame1;
    public GameObject Minigame2;
    public GameObject Minigame3;



    private bool entered1 = false;
    private bool entered2 = false;
    private bool entered3 = false;

    private bool info1 = false;
    private bool info2 = false;
    private bool info3 = false;
    private bool info4 = false;
    private bool info5 = false;
    private bool info6 = false;
    private bool info7 = false;
    private bool info8 = false;
    private bool info9 = false;
    private bool info10 = false;
    private bool info11 = false;
    private bool info12 = false;
    private bool info13 = false;
    private bool info14 = false;
    private bool info15 = false;



    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("skripte").gameObject.GetComponent<DotGame>().enabled = false;
        GameObject.Find("skripte").gameObject.GetComponent<CounterGame>().enabled = false;
        GameObject.Find("skripte").gameObject.GetComponent<DodgeGame>().enabled = false;
        GameObject.Find("Dot-Minigame-Start").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Counter-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Dodge-minigame").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (entered1 == true && Input.GetKeyDown("e")) {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<DotGame>().enabled = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas1.gameObject.SetActive(true);
        }

        if (entered2 == true && Input.GetKeyDown("e"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<CounterGame>().enabled = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas2.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Canvas2.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (entered3 == true && Input.GetKeyDown("e"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("skripte").gameObject.GetComponent<DodgeGame>().enabled = true;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas3.gameObject.transform.GetChild(3).GetComponent<MovePlayer>().enabled = true;
            Canvas3.gameObject.SetActive(true);
        }
        if (info1 == true && Input.GetKeyDown("e"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            this.transform.GetChild(1).GetComponent<MouseLook>().enabled = false;
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            InfoCanvas.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Minigame1 && DotGame.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered1 = true;
        }
        if (other.gameObject == Minigame2 && CounterGame.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered2 = true;
        }
        if (other.gameObject == Minigame3 && MovePlayer.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered3 = true;
        }
        if (other.gameObject.name.Contains("axe")) {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info1 = true;
        }
        if (other.gameObject.name.Contains("shield"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info2 = true;
        }
        if (other.gameObject.name.Contains("glass"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info3 = true;
        }
        if (other.gameObject.name.Contains("jug"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info4 = true;
        }
        if (other.gameObject.name.Contains("Plate"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info5 = true;
        }
        // -> TO DO ostalih 10 predmeta 

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Minigame1)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            entered1 = false;
        }
        if (other.gameObject == Minigame2)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("CanvasCounter").gameObject.transform.GetChild(1).gameObject.SetActive(false);
            entered2 = false;
        }
        if(other.gameObject == Minigame3)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Canvas3.gameObject.SetActive(false);
            entered3 = false;
        }
        if (other.gameObject.name.Contains("axe"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info1 = false;
        }
        if (other.gameObject.name.Contains("shield"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info2 = false;
        }
        if (other.gameObject.name.Contains("glass"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info3 = false;
        }
        if (other.gameObject.name.Contains("jug"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info4 = false;
        }
        if (other.gameObject.name.Contains("Plate"))
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            info5 = false;
        }
        // To Do -> ostalih 10 predmeta
    }


}