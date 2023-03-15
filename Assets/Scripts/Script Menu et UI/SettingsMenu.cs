using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    public void Start()
    {
        //Probl�me d'int�gration du DropDown dans le SettingMenu, il est actuellement 3h24 du matin, j'enchaine sur autre chose
        //resolutions = Screen.resolutions;
        //resolutionDropdown.ClearOptions();
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Music", volume);
    }
    public void SetSoundVolume(float volume)
    {
        audioMixer.SetFloat("Sound", volume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
