using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource source;

    [SerializeField] AudioClip clickSound;

    [SerializeField] List<AudioClip> hoverSounds;
    private AudioClip randomHoverSound;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void OnClick()
    {
        source.pitch = (Random.Range(.9f, 1.1f));
        source.clip = clickSound;
        source.Play();
    }
    public void OnHover()
    {
        randomHoverSound = hoverSounds[Random.Range(0, hoverSounds.Count)];
        source.clip = randomHoverSound;
        source.Play();
    }
}
