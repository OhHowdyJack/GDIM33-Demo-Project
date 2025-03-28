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
        [Tooltip("The unique name of the quest.")]
        public string Name;

        [Tooltip("A longer description of the quest.")]
        public string Description;

        [Tooltip("The required subject.")]
        public PhotoSubject Subject;
    }
}