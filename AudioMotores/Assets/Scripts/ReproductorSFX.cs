
using UnityEngine;

public class ReproductorSFX : MonoBehaviour
{
    [SerializeField] private AudioSource sonido;

    public void Reproducir()
    {
        if (sonido != null)
        {
            sonido.Play();
        }
        else
        {
            Debug.LogWarning("No hay un AudioSource asignado.");
        }
    }
}
