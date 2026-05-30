using UnityEngine;
using UnityEngine.SceneManagement;

public class pajarocontroller : MonoBehaviour
{
    [Header("Configuración del Salto")]
    public float fuerzaSalto = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.VelocityChange);
        }
    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("tubo"))
        {
            Credits();
        }
    }
    

    void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
