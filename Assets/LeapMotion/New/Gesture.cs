using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;

public class Gesture : MonoBehaviour {

    public Button button;
    Controller controller = new Controller();

	// Use this for initialization
	void Start () {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You clicked the button");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
