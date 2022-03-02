using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class PlayerAudio : AudioManager
{
    [Header("Footsteps")] public SoundCollection footSteps;
    public float footstepDelay;

    public AudioMixerSnapshot snapshot;
    private bool isMoving;
    private Coroutine footstepCoroutine;

    private void Start()
    {
       snapshot.TransitionTo(2);
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
