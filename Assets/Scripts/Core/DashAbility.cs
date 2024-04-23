using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DashAbility : MonoBehaviour
{
    public Rigidbody2D rb; // Cette variable va contenir la référence au Rigidbody2D du joueur.
    public float dashSpeed = 10f;
    public float dashDuration = 0.1f;
    public float dashCooldown = 1f;

    private bool isDashing = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !isDashing)
        {
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        isDashing = true;

        // Sauvegarde de la vélocité actuelle
        Vector2 savedVelocity = rb.velocity;

        // Calcul de la direction du dash
        Vector2 dashDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        // Application de la vélocité du dash
        rb.velocity = dashDirection * dashSpeed;

        // Attendre la durée du dash
        yield return new WaitForSeconds(dashDuration);

        // Réinitialisation de la vélocité
        rb.velocity = savedVelocity;

        // Attendre le temps de recharge du dash
        yield return new WaitForSeconds(dashCooldown);

        isDashing = false;
    }
}
