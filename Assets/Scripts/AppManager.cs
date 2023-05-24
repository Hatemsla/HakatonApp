using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using HakatonApp;
using Npgsql;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public AppManagerUI appManagerUI;
    public MenuManager menuManager;
    public User User;
    public ErrorWindow errorWindow;
    public HakatonInfoManager hakatonInfoManager;

    private DBHelper _dbHelper;
    
    private void Start()
    {
        _dbHelper = new DBHelper();
        User = new User();
        menuManager.OpenMenu("AuthMenu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuManager.OpenSubMenu("MainMenu");
            menuManager.OpenMenu("MainMenu");
        }
    }

    public void GoToReg()
    {
        menuManager.OpenMenu("RegMenu");
        ClearInputs();
    }
    
    public void GoToAuth()
    {
        menuManager.OpenMenu("AuthMenu");
        ClearInputs();
    }

    public void SignIn()
    {
        if (!_dbHelper.AuthUser(appManagerUI.loginAuthInput.text, appManagerUI.passwordAuthInput.text))
        {
            errorWindow.ShowError("Неверный логин или пароль!");
            return;
        }

        User = new User(appManagerUI.loginAuthInput.text, appManagerUI.passwordAuthInput.text,
            _dbHelper.GetUserRole(appManagerUI.loginAuthInput.text));
        menuManager.OpenMenu("MainMenu");
        menuManager.OpenSubMenu("MainMenu");
        ClearInputs();
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
            errorWindow.ShowError("Такой пользователь уже есть!");
            return;
        }

        menuManager.OpenMenu("MainMenu");
        menuManager.OpenSubMenu("MainMenu");
        ClearInputs();
    }

    public void HakatonsInfo()
    {
        hakatonInfoManager.ClearHakatonsInfoPanel();
        var hakatons = _dbHelper.GetHakatonsInfo(User.Login);
        for (int i = 0; i < hakatons.Count; i++)
        {
            hakatonInfoManager.CreateHakatonsInfoPanels(hakatons[i]);
        }
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
        appManagerUI.userName.text = User.Login;
        menuManager.OpenMenu("UserMenu");
    }

    public void SaveUserSettings()
    {
        _dbHelper.UpdatePassword(User.Login, appManagerUI.updatePasswordInput.text);
    }

    public void GoToMainMenu()
    {
        menuManager.OpenMenu("MainMenu");
        menuManager.OpenSubMenu("MainMenu");
        ClearInputs();
    }

    public void ExitFromAcc()
    {
        menuManager.OpenMenu("AuthMenu");
        ClearInputs();
    }

    private void ClearInputs()
    {
        appManagerUI.loginAuthInput.text = "";
        appManagerUI.loginRegInput.text = "";
        appManagerUI.passwordAuthInput.text = "";
        appManagerUI.passwordRegInput.text = "";
        appManagerUI.updatePasswordInput.text = "";
        appManagerUI.confirmPasswordRegInput.text = "";
    }
}
