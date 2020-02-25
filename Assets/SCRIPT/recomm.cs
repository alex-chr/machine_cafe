using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recomm : MonoBehaviour {
  public Button btnRecom;
	// Use this for initialization
	void Start () {
    btnRecom.onClick.AddListener(delegate {restart();});
	}

  void restart() {
    Application.LoadLevel(Application.loadedLevel);
  }

	// Update is called once per frame
	void Update () {

	}
}
