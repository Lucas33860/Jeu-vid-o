using System.Collections;

using System.Collections.Generic;

using UnityEngine;
public class Clignoteur : MonoBehaviour

{
public int dureeClignotement = 1;
private float timer = 0f;
    private bool isActive = false;
    private void Start()
    {
        // Désactiver tous les objets enfants du gameObject porteur du script
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= dureeClignotement)
        {
            isActive = !isActive;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(isActive);
            }
            timer = 0f;

        }
    }
}
