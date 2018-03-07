using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ToggleTablica : MonoBehaviour, IInputClickHandler {

    Animator animator;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        
    }

    public void explodeWhiteboard()
    {
        animator.Play("ExplodeTablica");
    }

    public void openWhiteboard()
    {
        animator.Play("OpenTablica");
    }
    public void closeWhiteboard()
    {
        animator.Play("HidePartsTablica");
    }
    public void hideWhiteboard()
    {
        animator.Play("CloseTablica");
    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
