using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class AffichageDecompte : MonoBehaviour
{
    [SerializeField]
    private InfosNiveau _infosNiveau;

    [SerializeField] private Niveau _scriptNiveau;

    [SerializeField]
    private TMP_Text _champTexteTemps;


    public void AfficherTemps(){
        float temps = _infosNiveau.temps;

        if(temps <0){
            temps = 0;
            
        }


        //Convertir le temps en secondes
        TimeSpan ts = TimeSpan.FromSeconds(temps);

        _champTexteTemps.text = string.Format("{0:00}:{1:00}", ts.Minutes,ts.Seconds);
    }

}
