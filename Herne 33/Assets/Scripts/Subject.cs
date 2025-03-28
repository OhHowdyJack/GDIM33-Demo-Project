using UnityEngine;

namespace GDIM33Demo
{
    public class Subject : MonoBehaviour
    {
        [SerializeField] private PhotoSubject _photoSubjectType;
        public PhotoSubject PhotoSubjectType => _photoSubjectType;
    }
}