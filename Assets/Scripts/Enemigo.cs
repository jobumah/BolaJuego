using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    public Transform playerTransform;
    public static int vecesMuerto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        playerTransform = FindAnyObjectByType<Esfera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = playerTransform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Esfera"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
