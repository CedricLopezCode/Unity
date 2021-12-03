using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boucles : MonoBehaviour
{
    int j = 0;
    int k = 0;
    public int[] tab; //{1, 3, 5}

    void Start()
    {
        BoucleSimples();
        Tableaux();
    }
    void BoucleSimples()
    {
        for(int i=0; i<5; i++){
            print("For = " + i);
        }
        while (j<5)
        {
             print("While = " + j);
             j++;
        }
        do
        {
            print("Do While = " + k);
             k++;
        } while (k<5);
        while (j<5)
        {
             print("While bis= " + j);
             j++;
        }
        do
        {
            print("Do While bis= " + k);
             k++;
        } while (k<5);

    }
    void Tableaux()
    {
        tab[0] = 42;
        print("Tableau = " + tab[0]);
        print("Tableau entier = " + tab);
        print("Longueur = " + tab.Length);
        for(int i=0; i<tab.Length; i++){
            print("Tableau For " + i + " = " + tab[i]);
        }
        foreach (int valeur in tab) {
            print("Tableau ForEach = " + valeur);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
