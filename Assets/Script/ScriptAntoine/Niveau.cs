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

    [Header("Information pour script")]
    [SerializeField] private GameObject _porte;

    [SerializeField] private Material porteActive;

    [Header("Information pour audio")]

    [SerializeField] private AudioClip _sonPorte;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _textNomJoueur.text = _infoJoueur.nomJoueur;
        _audioSource = _porte.GetComponent<AudioSource>();
        
    }
    void Update(){
        _textNombreDePoints.text = _infoJoueur.nbPoints.ToString();
        _textNombreDeMelons.text = _infoJoueur.nbPointsMelon.ToString();
        VerifierVictoire();
    }
    public void VerifierVictoire(){
        if(_infoJoueur.nbPointsMelon <= 0){
            
            _porte.GetComponent<MeshRenderer> ().material = porteActive;
            _porte.GetComponent<ZoneLevel3>().enabled = true;
            _audioSource.clip = _sonPorte;
            _audioSource.Play();
        }
    }

    public void Defaite(){
        _gestionnaireScene.SceneSuivante();
    }
}
