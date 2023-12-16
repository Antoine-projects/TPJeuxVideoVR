using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Niveau : MonoBehaviour
{
    [SerializeField] private GestionnaireScenes _gestionnaireScene;

    [Header("Les informations gardées en mémoire")]
    [SerializeField] private InfosJoueurs _infoJoueur;

    [Header("Information pour les Canvas")]
    [SerializeField] private TMP_Text _textNomJoueur;

    [SerializeField] private TMP_Text _textNombreDePoints;

    [SerializeField] private TMP_Text _textNombreDeMelons;

    [SerializeField] private GameObject _porte;

    // Start is called before the first frame update
    void Start()
    {
        _textNomJoueur.text = _infoJoueur.nomJoueur;
        
    }
    void Update(){
        _textNombreDePoints.text = _infoJoueur.nbPoints.ToString();
        _textNombreDeMelons.text = _infoJoueur.nbPointsMelon.ToString();
        VerifierVictoire();
    }
    public void VerifierVictoire(){
        if(_infoJoueur.nbPointsMelon == 0){
            //_porte.setActive(false);
        }
    }

    public void Defaite(){
        _gestionnaireScene.SceneSuivante();
    }
}
