using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonctionsMethodes : MonoBehaviour
{
    float aleatoire = Random.Range(-10.0f, 356.0f); // min max
    float pourCouleur = Random.Range(0.0f, 1.0f);
    Color nvCol = new Color(pourCouleur, pourCouleur, pourCouleur, pourCouleur); // !!!! Entre 0 et 1
    void Start() { // == Constructeur
        LesInvokes(); //principalement pour les void sans parametres
    }
    void Awake()  { //Se lance avant start
        print("Awake se lance avant start");
    }
    
    void Update() { //Se répète en continue mais consomme pas mal de ressource
        if (false == false){
            CancelInvoke(); //Annule tous les Invoke
        }
    }
    void LesInvokes()  { 
        Invoke("PourLeRepeting", 10.5f);  // Décaler dans le temps l'exécution de la fonction
        //public void InvokeRepeating(string methodName, float tempsAvantle1erLancement, float intervalleEntreLesRepetitions); 
        InvokeRepeating("PourLeRepeting", 1.5f, 0.7f);  //se répète à l'infini après 
        //permet de verifier de temps en temps sans gaspiller trop de ressource par rapport au update
        Invoke("CancelInvoke", 100.5f); //Arrete les invoque en cours
    }
    void PourLeRepeting() {
        print("PourLeRepeting");
    }
     
    IEnumerator PourAttendre5sec() {
        yield return new WaitForSeconds(5.0f);
    }
    IEnumerator PourAttendreXsec(float attente)  {
        yield return new WaitForSeconds(attente);
    }
    
    void ModifierCouleurUtilisee(){
        //Acceder à l'objet en cours <type> .attributs/enfants
        GetComponent<Renderer>().material.color = nvCol;
    }
}
