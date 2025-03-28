using UnityEngine;
using Unity.VisualScripting;

public enum PhotoSubject
{
    Jellyfish
}

namespace GDIM33Demo
{
    [CreateAssetMenu(fileName = "Quest", menuName = "ScriptableObjects/Quest", order = 1)]
    public class Quest : ScriptableObject
    {
        //---------------------------------------------------------------------
        // Variables
        //---------------------------------------------------------------------
        [Tooltip("The unique name of the quest.")]
        public string Name;

        [Tooltip("A longer description of the quest.")]
        public string Description;

        [Tooltip("The required subject.")]
        public PhotoSubject Subject;

        //---------------------------------------------------------------------
        // Properties
        //---------------------------------------------------------------------
        private bool _successfulPhotoTaken;
        public bool SuccessfulPhotoTaken => _successfulPhotoTaken;

        private bool _completed;
        public bool Completed => _completed;

        //---------------------------------------------------------------------
        // Methods
        //---------------------------------------------------------------------
        public void MarkSuccessfulPhotoTaken ()
        {
            _successfulPhotoTaken = true;
        }

        //---------------------------------------------------------------------
        public void CompleteQuest ()
        {
            _completed = true;
        }
    }
}