using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class PlayerAudio : MonoBehaviour
{
    [Header("Footsteps")] public SoundCollection footSteps;
    public float footstepDelay;

    private bool isMoving;
    private Coroutine footstepCoroutine;
    private AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnMove(InputAction.CallbackContext value)
    {
        isMoving = value.performed;
        if (isMoving && footstepCoroutine == null)
            footstepCoroutine = StartCoroutine(FootstepsSoundsCoroutine());
    }

    private IEnumerator FootstepsSoundsCoroutine()
    {
        while (isMoving)
        {
            audioSource.PlayOneShot(footSteps.GetRandomClip());
            yield return new WaitForSeconds(footstepDelay);
        }
    }
}
