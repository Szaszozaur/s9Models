using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ToggleOkno : MonoBehaviour, ISpeechHandler
{

    Animator animator;


    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        
    }
    public void openWindow()
    {
        animator.Play("OpenOkno");
    }

    public void explodeOkno()
    {
        animator.Play("ExplodeOkno");
    }
    public void hideOkno()
    {
        animator.Play("CloseOkno");
    }
    public void closeOkno()
    {
        animator.Play("HidePartsOkno");
    }
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
