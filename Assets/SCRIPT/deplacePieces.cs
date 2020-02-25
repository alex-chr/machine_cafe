using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deplacePieces : MonoBehaviour {
  public TextMesh texteAffiche;
  public int valeurPiece;
  public InputField memoireArgent, piecePlus;
  private Vector3 mPosition;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
    mPosition = Input.mousePosition;
	}

  void OnMouseDrag() {
    Vector3 val = (Input.mousePosition - mPosition) * Time.deltaTime;
    transform.Translate(val);
  }

  void OnCollisionEnter2D(Collision2D col) {
    if (col.gameObject.tag == "machine") {
      Destroy (gameObject);
      int valArgent = int.Parse(memoireArgent.text);
      int nbPiece = int.Parse(piecePlus.text);
      valArgent += valeurPiece;
      nbPiece++;
      float valAffiche = (float)valArgent;
      valAffiche = valAffiche/10f;
      texteAffiche.text = valAffiche + " euros";
      memoireArgent.text = valArgent.ToString();
      piecePlus.text = nbPiece.ToString();
    }
  }
}
