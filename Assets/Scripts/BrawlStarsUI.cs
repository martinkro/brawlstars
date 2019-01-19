using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrawlStarsUI : MonoBehaviour {

    [SerializeField] private Text scoreLabel;
    public Button btnAddHP;

    public void DumpResolutions()
    {
        Resolution[] resolutions = Screen.resolutions;
        foreach(Resolution res in resolutions)
        {
            Debug.Log(string.Format("resolution:{0}x{1}",res.width,res.height));
        }
    }
	// Use this for initialization
	void Start () {
        btnAddHP.onClick.AddListener(OnAddHP);
        scoreLabel.text = "Score:100";
        Debug.Log("BrawlStarsUI.Start");
        Debug.Log(string.Format("Screen Width:{0}", Screen.width));
        Debug.Log(string.Format("Screen Height:{0}", Screen.height));
        DumpResolutions();
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
