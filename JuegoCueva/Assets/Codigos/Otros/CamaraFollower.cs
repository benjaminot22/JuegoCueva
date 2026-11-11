using UnityEngine;

public class CamaraFollower : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 desfasamiento = new Vector3(0, 0, -10f);
    public float suavidad = 5f;

    void LateUpdate()
    {
        if (objetivo != null)
        {
            Vector3 posicionDeseada = objetivo.position + desfasamiento;
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavidad * Time.deltaTime);
        }
    }
}