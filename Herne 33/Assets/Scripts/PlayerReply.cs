using System;
using System.Collections.Generic;
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