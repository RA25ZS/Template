using Prototype.Base;
using Prototype.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Prototype
{
    public class GameScreen : BaseScreen
    {
        public const string Exit_Settings = "Exit_Settings";
        public const string Exit_Result = "Exit_Result";

        public void ShowAndStartGame()
        {
            Show();

            GameInfo.Instance.Scores = 10;
        }

        public void OnSettingsPressed()
        {
            Exit(Exit_Settings);
        }

        public void OnEndGamePressed()
        {
            Exit(Exit_Result);
        }
    }
}
