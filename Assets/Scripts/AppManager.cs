using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Npgsql;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public AppManagerUI appManagerUI;
    public MenuManager menuManager;
    public User user;

    private DBHelper _dbHelper;
    
    private void Start()
    {
        _dbHelper = new DBHelper();
        user = new User();
        menuManager.OpenMenu("AuthMenu");   
    }

    public void GoToReg()
    {
        menuManager.OpenMenu("RegMenu");
    }
    
    public void GoToAuth()
    {
        menuManager.OpenMenu("AuthMenu");
    }

    public void SignIn()
    {
        if(!_dbHelper.AuthUser(appManagerUI.loginAuthInput.text, appManagerUI.passwordAuthInput.text))
            return;

        user = new User(appManagerUI.loginAuthInput.text, appManagerUI.passwordAuthInput.text,
            _dbHelper.GetUserRole(appManagerUI.loginAuthInput.text));
        menuManager.OpenMenu("MainMenu");
        menuManager.OpenSubMenu("MainMenu");
    }

    public void SingUp()
    {
        try
        {
            _dbHelper.RegUser(appManagerUI.loginRegInput.text, appManagerUI.passwordRegInput.text, Roles.postgres);
            
        }
        catch (NpgsqlException e)
        {
            Debug.Log(e);
            return;
        }

        menuManager.OpenMenu("MainMenu");
        menuManager.OpenSubMenu("MainMenu");
    }

    public void HakatonsInfo()
    {
        menuManager.OpenSubMenu("HakatonsInfoMenu");
    }

    public void EditTables()
    {
        menuManager.OpenSubMenu("EditTablesMenu");
    }

    public void StatsTasks()
    {
        menuManager.OpenSubMenu("StatsTasksMenu");
    }

    public void StatsTeams()
    {
        menuManager.OpenSubMenu("StatsTeamsMenu");
    }

    public void OpenUser()
    {
        appManagerUI.userName.text = user.Login;
        menuManager.OpenMenu("UserMenu");
    }

    public void SaveUserSettings()
    {
        
    }

    public void GoToMainMenu()
    {
        menuManager.OpenMenu("MainMenu");
    }

    public void ExitFromAcc()
    {
        menuManager.OpenMenu("AuthMenu");
    }
}
