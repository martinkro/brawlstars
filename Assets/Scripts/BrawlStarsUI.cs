using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrawlStarsUI : MonoBehaviour {

    [SerializeField] private Text scoreLabel;
	// Use this for initialization
	void Start () {
        scoreLabel.text = "Score:100";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnAddHP()
    {
        Debug.Log("On Add HP");
    }
}
