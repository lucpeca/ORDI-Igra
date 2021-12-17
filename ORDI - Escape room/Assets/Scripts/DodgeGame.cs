using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DodgeGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas cavnas;

    RectTransform canvas;
    List<RectTransform> Enpos;

    public Button player;
    public Button win;
    public List<Button> enemies;



    public static bool won = false;
    public bool winonce = false;
    public float speed;



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
