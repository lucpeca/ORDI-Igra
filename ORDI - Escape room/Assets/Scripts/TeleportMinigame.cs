using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportMinigame : MonoBehaviour
{
    private Vector3 respawnPosition;
    private GameObject floorOfDeath;
    private bool spremanZaTeleport = false;
    public PlayerMovement playerMovement;
    private bool cekajMalo = false;
    private bool spremanZaPovratak = false;
    private GameObject gumbSpasa;
    private Vector3 returningPosition;
    private bool rutinaZaPovratak = false;
    static public bool Won = false;
    public Canvas Cnv;
    private bool winonce = false;

    // Start is called before the first frame update
    void Start()
    {

        Won = false;
        respawnPosition = new Vector3(31.2479992f, 1.03999996f, 9.46700001f);
        returningPosition = new Vector3(5.30499983f, 1.35000002f, 5.01000023f);

        floorOfDeath = GameObject.Find("PodSmrti");
        gumbSpasa = GameObject.Find("GumbSpasa");
        playerMovement = gameObject.GetComponent<PlayerMovement>();



        StartCoroutine("StartTeleport");
    }

    // Update is called once per frame
    void Update()
    {
        if (!cekajMalo) {
            if (spremanZaTeleport)
            {
                StartCoroutine("Teleport");

            }
        }
        if (!rutinaZaPovratak)
        {
            if (spremanZaPovratak)
            {
                Won = true;
                if (winonce == false) { 
                Cnv.transform.GetChild(3).gameObject.GetComponent<Text>().text = Cnv.transform.GetChild(3).gameObject.GetComponent<Text>().text + " 33";
                    winonce = true;
            }
                StartCoroutine("TeleportBack");


            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(gumbSpasa))
        {
            spremanZaPovratak = true;
        }


        if (other.gameObject.Equals(floorOfDeath))
            {
                spremanZaTeleport = true;
            }
    }

    IEnumerator TeleportBack()
    {
        cekajMalo = true;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = true;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = false;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = returningPosition;
        yield return new WaitForSeconds(0.01f);
        spremanZaPovratak = false;
        yield return new WaitForSeconds(0.01f);
        rutinaZaPovratak = false;
        yield return new WaitForSeconds(0.01f);
        GetComponent<TeleportMinigame>().enabled = false;
    }
    IEnumerator Teleport() {
        cekajMalo = true;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = true;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = respawnPosition;

        yield return new WaitForSeconds(0.01f);

        spremanZaTeleport = false;
        yield return new WaitForSeconds(0.01f);

        playerMovement.disabled = false;
        yield return new WaitForSeconds(0.01f);
        cekajMalo = false;
    }

    IEnumerator StartTeleport()
    {
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = true;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = respawnPosition;
        yield return new WaitForSeconds(0.01f);
        playerMovement.disabled = false;
    }
}
