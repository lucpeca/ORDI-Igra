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

    public Button[] buttons;



    void Start()
    {
        Button button0 = GameObject.Find("button (0)").GetComponent<Button>();
        Debug.Log(button0.GetComponent<Image>().color);
        Debug.Log(button0);

        Button button1 = GameObject.Find("button (1)").GetComponent<Button>();
        Button button2 = GameObject.Find("button (2)").GetComponent<Button>();
        Button button3 = GameObject.Find("button (3)").GetComponent<Button>();
        Button button4 = GameObject.Find("button (4)").GetComponent<Button>();
        Button button5 = GameObject.Find("button (5)").GetComponent<Button>();
        Button button6 = GameObject.Find("button (6)").GetComponent<Button>();
        Button button7 = GameObject.Find("button (7)").GetComponent<Button>();
        Button button8 = GameObject.Find("button (8)").GetComponent<Button>();
        Button button9 = GameObject.Find("button (9)").GetComponent<Button>();
        Button button10 = GameObject.Find("button (10)").GetComponent<Button>();
        Button button11 = GameObject.Find("button (11)").GetComponent<Button>();
        Button button12 = GameObject.Find("button (12)").GetComponent<Button>();
        Button button13 = GameObject.Find("button (13)").GetComponent<Button>();
        Button button14 = GameObject.Find("button (14)").GetComponent<Button>();
        Button button15 = GameObject.Find("button (15)").GetComponent<Button>();
        Button button16 = GameObject.Find("button (16)").GetComponent<Button>();
        Button button17 = GameObject.Find("button (17)").GetComponent<Button>();
        Button button18 = GameObject.Find("button (18)").GetComponent<Button>();
        Button button19 = GameObject.Find("button (19)").GetComponent<Button>();
        Button button20 = GameObject.Find("button (20)").GetComponent<Button>();
        Button button21 = GameObject.Find("button (21)").GetComponent<Button>();
        Button button22 = GameObject.Find("button (22)").GetComponent<Button>();
        Button button23 = GameObject.Find("button (23)").GetComponent<Button>();
        Button button24 = GameObject.Find("button (24)").GetComponent<Button>();

        buttons[0] = button0;
        buttons[1] = button1;
        buttons[2] = button2;
        buttons[3] = button3;
        buttons[4] = button4;
        buttons[5] = button5;
        buttons[6] = button6;
        buttons[7] = button7;
        buttons[8] = button8;
        buttons[9] = button9;
        buttons[10] = button10;
        buttons[11] = button11;
        buttons[12] = button12;
        buttons[13] = button13;
        buttons[14] = button14;
        buttons[15] = button15;
        buttons[16] = button16;
        buttons[17] = button17;
        buttons[18] = button18;
        buttons[19] = button19;
        buttons[20] = button20;
        buttons[21] = button21;
        buttons[22] = button22;
        buttons[23] = button23;
        buttons[24] = button24;

        foreach (Button btn in buttons) {
            btn.GetComponent<Image>().color = Color.red;
            btn.onClick.AddListener(() => ChangeColor(btn));
        }



        int xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);
        xcount = Random.Range(0, 25);
        ChangeColor(buttons[xcount]);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void ChangeColor(Button btn)
    {
        if (btn.GetComponent<Image>().color == Color.red)
        {
            btn.GetComponent<Image>().color = Color.green;
        }
        else {
            btn.GetComponent<Image>().color = Color.red;
        }

    }

}



