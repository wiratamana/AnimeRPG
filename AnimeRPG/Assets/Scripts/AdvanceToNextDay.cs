using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tamana
{
    public class AdvanceToNextDay : MonoBehaviour
    {
        public Animator animator;

        private void OnValidate()
        {
            animator = GetComponent<Animator>();
        }

        public void Show()
        {
            animator.Play("Show");
        }

        public void Hide()
        {
            animator.Play("Hide");
        }
    }

}
