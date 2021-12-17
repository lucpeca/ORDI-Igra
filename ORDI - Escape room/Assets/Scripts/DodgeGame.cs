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



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (RectTransform move in Enpos)
        {
            transform.Translate(0f, speed, 0f);
            if (move.position.y < -move.rect.height)
                transform.position = new Vector3(startingPosition.x,
                    canvas.rect.height + move.rect.height, startingPosition.z);
        }
        

        
    }
}
