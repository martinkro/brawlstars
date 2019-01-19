using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrawlStarsUI : MonoBehaviour {

    [SerializeField] private Text scoreLabel;
    public Button btnAddHP;
	// Use this for initialization
	void Start () {
        btnAddHP.onClick.AddListener(OnAddHP);
        scoreLabel.text = "Score:100";
        Debug.Log("BrawlStarsUI.Start");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnAddHP()
    {
        Debug.Log("On Add HP");
    }

    public void OnAddMP()
    {
        Debug.Log("On Add HP");
    }

    public void OnClick(GameObject sender)
    {
        Debug.Log("On Add HP");
    }
}
