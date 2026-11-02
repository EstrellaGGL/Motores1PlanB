using UnityEngine;

public class ControladorVoces : MonoBehaviour
{
    [SerializeField] private AudioSource dialogoInicio;
    [SerializeField] private AudioSource dialogoPowerUp;
    [SerializeField] private AudioSource dialogoCima;

    public void ReproducirDialogoInicio()
    {
        dialogoInicio.Play();
    }

    public void ReproducirDialogoPowerUp()
    {
        dialogoPowerUp.Play();
    }

    public void ReproducirDialogoCima()
    {
        dialogoCima.Play();
    }
}