using Prototype.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class SettingsScreen : BaseScreen
    {
        public const string Exit_Back = "Exit_Back";
        
        [SerializeField] BaseScreen backScreen;
        public void OnBackPressed()
        {
            Exit(Exit_Back);
        }
    }
}
