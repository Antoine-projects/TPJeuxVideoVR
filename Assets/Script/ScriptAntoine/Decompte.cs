using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decompte : MonoBehaviour
{
    [SerializeField] private InfosNiveau _infosNiveau;

    [SerializeField] private bool _decompteActif = false;

    public UnityEvent auChangementDuTemps;
    public UnityEvent aLaFinDuTemps;

    // Start is called before the first frame update
    void Start()
    {
        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if(_decompteActif){
            if(_infosNiveau.temps > 0){
                //On décrémente le temps
                _infosNiveau.temps -= Time.deltaTime;

                //On envoie l'événement
                auChangementDuTemps.Invoke();
            }
            else{
                _infosNiveau.temps = 0;
                _decompteActif = false;

                //On envoie l'événement
                aLaFinDuTemps.Invoke();
            }
        }
    }
    public void DemarrerDecompte(){
        //On réinitialise le temps
        _infosNiveau.temps = _infosNiveau.tempsInitial;
        _decompteActif = true;
    }
}