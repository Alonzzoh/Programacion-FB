using UnityEngine;

public class tubelios : MonoBehaviour
{
    public float velocidad = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);

    }
}
