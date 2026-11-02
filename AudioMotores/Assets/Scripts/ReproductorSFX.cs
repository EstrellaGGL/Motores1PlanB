using UnityEngine;

public class ReproductorSFX : MonoBehaviour
{
    [Header("Reproducción")]
    [SerializeField] private AudioSource sonido;

    [Header("Variaciones")]
    [SerializeField] private AudioClip[] variaciones;

    private int ultimoIndice = -1;

    public void Reproducir()
    {
        if (sonido == null || variaciones.Length == 0)
        {
            Debug.LogWarning("Falta asignar el AudioSource o los clips.");
            return;
        }

        int indice;

        do
        {
            indice = Random.Range(0, variaciones.Length);
        }
        while (variaciones.Length > 1 && indice == ultimoIndice);

        ultimoIndice = indice;

        sonido.PlayOneShot(variaciones[indice]);
    }
}