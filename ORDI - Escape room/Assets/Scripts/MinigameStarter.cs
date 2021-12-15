using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameStarter : MonoBehaviour
{
    public GameObject Minigame1;
    private bool entered = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Dot-Minigame-Start").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (DotGame.won == true)
        {
            GameObject.Find("Dot-Minigame-Start").gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (entered == true && Input.GetKeyDown("e")) {
            //GetComponent<PlayerMovement>().enabled = false;
            SceneManager.LoadScene("DotMinigame");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Minigame1 && DotGame.won == false)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            entered = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Minigame1)
        {
            GameObject.Find("Canvas").gameObject.transform.GetChild(0).gameObject.SetActive(false);
            entered = false;
        }
    }


}