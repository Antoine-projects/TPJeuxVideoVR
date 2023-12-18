using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Zombie: MonoBehaviour
{
        // le script GestionnaireScenes

    // Le joueur
    [SerializeField] private GameObject _joueur;
    [SerializeField] private GameObject _IdleTarget;
    [SerializeField] private GameObject _Arme;

  

     // Variable pour contenir la position du joueur
     private Vector3 _positionJoueur;
     private Vector3 _positionIdleTarget;

    // Variable pour faire référence à l'animateur du zombie
    private Animator _animator;

    public bool _isStopped;


   
    // Étape 1. Créer une variable privée pour la référence au composant NavMesh
    [SerializeField] private NavMeshAgent _agent;


    void Start()
    {
        // Récupère le composant Animator
        _animator = GetComponent<Animator>();

        // Étape 2. Récupérer le composant NavMesh si la variable ( étape 1) n'avait pas l'attribut [SerializeField]

    }



    // Update is called once per frame
    void Update()
    {
        BougerPolicier();
    }


    void BougerPolicier(){

        // Étape 3 . Besoin de la position  du joueur, pour donner une destination à l'agent
        _positionJoueur = _joueur.transform.position;
        _positionIdleTarget = _IdleTarget.transform.position;


        // Étape 4. Définir la destination de l'agent
        _agent.SetDestination(_positionJoueur);


        // Étape 5. Créer une variable de type float pour contenir la valeur de la distance entre l'agent et le joueur
        // https://docs.unity3d.com/ScriptReference/Vector3.Distance.html
             float _distance = Vector3.Distance(_agent.transform.position, _joueur.transform.position);
             float _distanceTarget = Vector3.Distance(_agent.transform.position, _positionIdleTarget);

        


        // Étape 6. Vérifier si la distance entre les deux est plus petite que 2. 
                if(_distance >= 10 && _isStopped == false){
                    _agent.SetDestination(_positionIdleTarget);
                    
                                       
                }
                else if(_distance < 10 && _distance >= 2){
                     _isStopped = false;
                    _animator.SetFloat("MoveSpeed", 1);
                    _agent.SetDestination(_positionJoueur);

                 
                }
                   else if(_distance < 2)
                {
                    _isStopped = true;
                    _animator.SetTrigger("Attack");
                    _animator.SetFloat("MoveSpeed", 0);

                  
                    
                }
                
                 if(_distanceTarget <= 1.5 && _distance >= 10){
                     _animator.SetFloat("speed", 0);
                    _isStopped = true;
                    _agent.Stop();
                    _agent.ResetPath();
                    
                }

                

              
        
               
               
    }



    void OnCollisionEnter(Collision other){
        if(other.transform.tag == "Arme"){

        
        GetComponent<Zombie>().enabled = false;
        _animator.SetTrigger("Dead");
        gameObject.GetComponent<NavMeshAgent>().enabled = false;
        }
    }

   

}
