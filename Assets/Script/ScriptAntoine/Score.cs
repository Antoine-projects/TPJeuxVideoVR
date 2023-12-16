using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [Header("Les informations gardées en mémoire")]
    [SerializeField] private InfosJoueurs _infoJoueur;

    [Header("Information pour les Canvas")]
    [SerializeField] private TMP_Text _textNombreDePoints;

    void Update(){
        _textNombreDePoints.text = _infoJoueur.nbPoints.ToString();
        Cursor.lockState = CursorLockMode.None;
    }
}
