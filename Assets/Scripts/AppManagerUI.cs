using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AppManagerUI : MonoBehaviour
{
    [Header("Auth menu")]
    public TMP_InputField loginAuthInput;
    public TMP_InputField passwordAuthInput;
    public Button signInBtn;
    public Button goToRegBtn;

    [Header("Reg Menu")]
    public TMP_InputField loginRegInput;
    public TMP_InputField passwordRegInput;
    public TMP_InputField confirmPasswordRegInput;
    public TMP_Dropdown roleDropdown;
    public Button singUpBtn;
    public Button goToAuthBtn;

    [Header("Main menu")]
    public Button userBtn;

    [Header("User menu")] 
    public TMP_Text userName;
    public TMP_InputField updatePasswordInput;
    public Button saveUserSettingsBtn;
}
