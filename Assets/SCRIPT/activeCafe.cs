using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class activeCafe : MonoBehaviour {
	public TextMesh texteAffiche;
  public GameObject piece2, piece1, piece50, piece20, piece10;
	public string typeCafe;
	public int prixCafe;
	public InputField argent, nbPiece2, nbPiece1, nbPiece50, nbPiece20, nbPiece10;
	private int nb2 = 0, nb1 = 0, nb50 = 0, nb20 = 0, nb10 = 0, valArgent;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		valArgent = int.Parse(argent.text);
		if (valArgent >= prixCafe) {
			valArgent -= prixCafe;
			texteAffiche.text = typeCafe;
			argent.text = valArgent.ToString();

			compterPieceARendre();
      rendreMonnaie();
		} else {
			texteAffiche.text = "Pas assez !!";
			argent.text = "0";
			// rendre l'argent déposer
		}
	}

	void compterPieceARendre() {
		while (valArgent > 0) {
			if (valArgent >= 20) {
				valArgent = valArgent - 20;
				nb2++;
			} else if (valArgent >= 10) {
				valArgent = valArgent - 10;
				nb1++;
			} else if (valArgent >= 5) {
				valArgent = valArgent - 5;
				nb50++;
			} else if (valArgent >= 2) {
				valArgent = valArgent - 2;
				nb20++;
			} else if (valArgent >= 1) {
				valArgent = valArgent - 1;
				nb10++;
			} else {
        valArgent = 0;
      }
		}
	}

  void rendreMonnaie() {
    rendrePiece(nb2, piece2, nbPiece2);
    rendrePiece(nb1, piece1, nbPiece1);
    rendrePiece(nb50, piece50, nbPiece50);
    rendrePiece(nb20, piece20, nbPiece20);
    rendrePiece(nb10, piece10, nbPiece10);

    argent.text = "0";

  }

  void rendrePiece(int nbRendre, GameObject piece, InputField compteurPiece) {
    while (nbRendre > 0) {
      Instantiate(piece);
      int nbPiece = int.Parse(compteurPiece.text);
      nbPiece--;
      compteurPiece.text = nbPiece.ToString();
      nbRendre--;
    }
  }

}
