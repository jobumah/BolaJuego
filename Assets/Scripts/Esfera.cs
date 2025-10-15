using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Esfera : MonoBehaviour
{
    public Rigidbody rb;
    public Vector2 mov;
    private float movimientoX;
    private float movimientoY;
    public float velocidad = 5;

    private void OnMove(InputValue movimientos)
    {
        mov = movimientos.Get<Vector2>();
        movimientoX = mov.x;
        movimientoY = mov.y;  

        Debug.Log(movimientoX + " " + movimientoY);
        

    }

    private void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(movimientoX, 0.0f, movimientoY);
        rb.linearVelocity = movimiento * velocidad;
    }
}
