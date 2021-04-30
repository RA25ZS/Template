using Prototype.Base;
using Prototype.Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Prototype
{
    public class MenuScreen : BaseScreen
    {
        public const string Exit_Settings = "Exit_Settings";
        public const string Exit_Game = "Exit_Game";

        [SerializeField] TextMeshProUGUI scoreText;
        public override void Show()
        {
            base.Show();
            scoreText.text = GameInfo.Instance.Scores.ToString();
        }

        public void OnSettingsPressed()
        {
            Exit(Exit_Settings);
        }

        public void OnGamePressed()
        {
            Exit(Exit_Game);
        }
    }
}
