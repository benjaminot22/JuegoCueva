using UnityEngine;

public class Recolectar3 : MonoBehaviour
{
    [Header("Configuración de Recolección")]
    public int cantidadNecesaria = 8; // Cantidad de objetos para activar el premio
    private int objetosRecolectados = 0;

    [Header("Objeto a Aparecer")]
    public GameObject prefabObjetoNuevo; // El Prefab del objeto que aparecerá
    public Transform puntoDeAparicion;   // Lugar exacto donde aparecerá

    private bool yaAparecio = false; // Evita que aparezca múltiples veces

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si tocamos un objeto con el Tag "Recolectable"
        if (collision.CompareTag("Gema"))
        {
            objetosRecolectados++; // Suma 1 al contador


            // Verifica si llegamos a la meta y el objeto aún no ha aparecido
            if (objetosRecolectados >= cantidadNecesaria && !yaAparecio)
            {
                HacerAparecerObjeto();
            }
        }
    }

    void HacerAparecerObjeto()
    {
        yaAparecio = true;
        // Crea el objeto nuevo en la posición y rotación del punto de aparición
        Instantiate(prefabObjetoNuevo, puntoDeAparicion.position, puntoDeAparicion.rotation);
        Debug.Log("¡Ha aparecido el portal!");
    }
}
