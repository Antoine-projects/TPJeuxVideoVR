using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Collisions : MonoBehaviour
{
    [SerializeField] private InfosJoueurs _infoJoueur;

    [SerializeField] private Niveau _scriptNiveau;

    [SerializeField] private AudioClip _sonPoint;

    [SerializeField] private AudioClip _sonErreur;

    [SerializeField] private GameObject _panier;
    private AudioSource _audioSource;

   void Start(){
    _audioSource = _panier.GetComponent<AudioSource>();
   } 

   private void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "Point"){
        _infoJoueur.nbPointsMelon--;
        _infoJoueur.nbPoints++;
       
        _audioSource.clip = _sonPoint;
        _audioSource.Play();

        Destroy(other.gameObject);
        //_audioSource.Play();
    }
    else if(other.gameObject.tag == "Untagged"){
        _infoJoueur.nbPoints--;

        _audioSource.clip = _sonErreur;
        _audioSource.Play();
       
        Destroy(other.gameObject);
        //_audioSource.Play();
    }
   }
}
