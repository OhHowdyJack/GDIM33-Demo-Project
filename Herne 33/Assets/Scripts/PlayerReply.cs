using System;
using UnityEngine;
using Unity.VisualScripting;

namespace GDIM33Demo
{
    [Serializable][Inspectable]
    public class PlayerReply
    {
        [Inspectable]
        public string line;
        [Inspectable]
        public DialogueNode nextNode;
    }
}