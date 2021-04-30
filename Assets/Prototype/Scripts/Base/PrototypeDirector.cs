using Prototype.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Prototype.Base
{
    public class PrototypeDirector : AppDirector
    {
        protected override void Awake()
        {
            base.Awake();
            SceneManager.LoadScene("Menu");
        }
    }
}
