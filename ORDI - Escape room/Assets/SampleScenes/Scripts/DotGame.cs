using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotGame : MonoBehaviour
{
    // Start is called before the first frame update
    public Material Material1;
    public Material Material2;
    public GameObject[] Object;

    void Start()
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
