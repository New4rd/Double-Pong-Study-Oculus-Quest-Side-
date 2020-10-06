using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ServerToClientManager : NetworkBehaviour
{
    private Material material;

    [SyncVar(hook = "SwitchMaterialColor")]
    public Color transpColor;

    [SyncVar(hook = "EditDisplayText")]
    public string textToDisplay;

    private void Awake()
    {
        material = (Material)Resources.Load("Materials/TransparentRacketMaterial");
        material.color = Color.gray;
    }


    private void EditDisplayText (string displayText)
    {
        GameObject.Find("Instructions Displayer(Clone)").gameObject.transform.GetChild(0).GetComponent<Text>().text = displayText;
    }


    private void SwitchMaterialColor (Color color)
    {
        Debug.Log("COLOR CHANGE!");
        transpColor = color;
        material.color = transpColor;
    }
}
