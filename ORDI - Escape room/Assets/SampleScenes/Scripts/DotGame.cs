using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Material Material1;
    public Material Material2;
    public Canvas Canvas;
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;
    public Button button13;
    public Button button14;
    public Button button15;
    public Button button16;
    public Button button17;
    public Button button18;
    public Button button19;
    public Button button20;
    public Button button21;
    public Button button22;
    public Button button23;
    public Button button24;


    void Start()
    {
        UnityEngine.UI.Button button0 = GameObject.Find("button (0)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button1 = GameObject.Find("button (1)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button2 = GameObject.Find("button (2)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button3 = GameObject.Find("button (3)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button4 = GameObject.Find("button (4)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button5 = GameObject.Find("button (5)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button6 = GameObject.Find("button (6)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button7 = GameObject.Find("button (7)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button8 = GameObject.Find("button (8)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button9 = GameObject.Find("button (9)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button10 = GameObject.Find("button (10)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button11 = GameObject.Find("button (11)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button12 = GameObject.Find("button (12)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button13 = GameObject.Find("button (13)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button14 = GameObject.Find("button (14)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button15 = GameObject.Find("button (15)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button16 = GameObject.Find("button (16)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button17 = GameObject.Find("button (17)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button18 = GameObject.Find("button (18)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button19 = GameObject.Find("button (19)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button20 = GameObject.Find("button (20)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button21 = GameObject.Find("button (21)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button22 = GameObject.Find("button (22)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button23 = GameObject.Find("button (23)").GetComponent<UnityEngine.UI.Button>();
        UnityEngine.UI.Button button24 = GameObject.Find("button (24)").GetComponent<UnityEngine.UI.Button>();

        button0.onClick.AddListener(() => ChangeColor(button0));
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ChangeColor(Button btn)
    {
        if (btn.image.material = Material1)
        {
            btn.image.material = Material2;
        }
        else {
            btn.image.material = Material1;
        }

    }

}



