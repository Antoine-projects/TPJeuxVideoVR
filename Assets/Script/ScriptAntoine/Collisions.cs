using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Collisions : MonoBehaviour
{
    [SerializeField] private InfosJoueurs _infoJoueur;

    [SerializeField] private Niveau _scriptNiveau;

    [SerializeField] private GameObject _sonPoint;

    private AudioSource _audioSource;

   void Start(){
    _audioSource = _sonPoint.GetComponent<AudioSource>();
   } 

   private void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "Point"){
        _infoJoueur.nbPointsMelon--;
        _infoJoueur.nbPoints++;
       
        Destroy(other.gameObject);
        //_audioSource.Play();
    }
    else if(other.gameObject.tag == "Untagged"){
        _infoJoueur.nbPoints--;
       
        Destroy(other.gameObject);
        //_audioSource.Play();
    }
   }
}
