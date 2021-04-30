using Prototype.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Prototype
{
    public class MenuDirector : SceneDirector
    {
        
        protected override void Start()
        {
            base.Start();

            SetCurrentScreen<MenuScreen>().Show();
        }

        protected override void OnScreenExit(Type _screenType, string _exitCode)
        {
            if(_screenType == typeof(MenuScreen))
            {
                if (_exitCode == MenuScreen.Exit_Game)
                    SceneManager.LoadScene(SceneIds.Game);
                
                else if (_exitCode == MenuScreen.Exit_Settings)          
                    SetCurrentScreen<SettingsScreen>().Show();
                
            }

            else if (_screenType == typeof(SettingsScreen))
            {
                if (_exitCode == SettingsScreen.Exit_Back)
                    ToBackScreen();
            }
        }
    }
}
