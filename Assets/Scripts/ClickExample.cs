using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ClickExample : MonoBehaviour, IInputClickHandler {

    private Color[] colors = new Color[] { Color.red, Color.cyan };
    private int i = 0;
    private Renderer rend;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        rend.material.color = colors[i];
        i = (i + 1) % colors.Length;
    }

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
