using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour {
	public Camera m_camera;
    Vector3 menuPosition = new Vector3(340, 315, -880); 
    Vector3 optionsPosition = new Vector3(775, 315, -880);

    // Use this for initialization
    void Start () {
		Debug.Log("StateManager Started");

    }
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadLevel() {
		Debug.Log("Load Level Scene");
		SceneManager.LoadScene ("levelScene");
	}

	public void loadGame() {
		Debug.Log("Load Game Scene");
		SceneManager.LoadScene ("gameScene");
	}

	public void logger(){
		Debug.Log("Button Pressed");
	}

	public void changeViewOption() {
		Debug.Log("Options Menu");
        Camera.main.transform.position = optionsPosition;
        
    }

	public void changeViewMain() {
        Debug.Log("Main Menu");
        Camera.main.transform.position = menuPosition;
	}

	void changeView() {
		//Camera.main.transform.position ();
	}
}
