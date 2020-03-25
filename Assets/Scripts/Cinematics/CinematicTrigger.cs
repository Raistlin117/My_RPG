using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour
    {
        private bool alreadyTriggered = false;
        private void OnTriggerEnter(Collider other)
        {
            IntroSequence(other);
        }

        private void IntroSequence(Collider other)
        {
            if (other.gameObject.tag == "Player" && !alreadyTriggered)
            {
                GetComponent<PlayableDirector>().Play();
                alreadyTriggered = true;
            }
        }
    }
}

