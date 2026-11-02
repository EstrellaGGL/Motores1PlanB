using UnityEngine;

public class DetectorAterrizaje : MonoBehaviour
{
    [SerializeField] private ReproductorSFX sonidoAterrizaje;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            foreach (ContactPoint contacto in collision.contacts)
            {
                if (contacto.normal.y > 0.5f)
                {
                    sonidoAterrizaje.Reproducir();
                    break;
                }
            }
        }
    }
}