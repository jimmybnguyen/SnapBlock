using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeMaterial : MonoBehaviour
{
    public GameObject display;

    int i = 0;
    public Material[] myMaterials;

    // Use this for initialization
    void Start()
    {
        myMaterials = myMaterials.GetComponent(typeof(Material)) as Material;
        /*
        instruction = display.GetComponent(typeof(TextMesh)) as TextMesh;
        Debug.Log("starting instruction: " + instruction.text);
        instruction.text = instructions[i];
        Debug.Log("0: " + instruction.text);
        */
    }

    void OnTriggerEnter(Collider col)
    {
        /*
        instruction = display.GetComponent(typeof(TextMesh)) as TextMesh;
        i += 1;
        Debug.Log("prev instruction: " + instruction.text);
        Debug.Log("triggered, i = " + i);
        instruction.text = instructions[i];
        Debug.Log(i + ": " + instruction.text);
        */
        myMaterials = myMaterials.GetComponent(typeof(Material)) as Material;
    }
}
