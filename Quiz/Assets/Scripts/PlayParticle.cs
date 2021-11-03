using UnityEngine;

public class PlayParticle : MonoBehaviour
{
    public void ParticlePlay(GameObject card)
    {
        ParticleSystem particleSystem = card.transform.GetComponent<ParticleSystem>();
        particleSystem.Play();
    }
}
