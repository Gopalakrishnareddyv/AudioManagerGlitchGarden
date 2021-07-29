using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMAnager : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider difficultySlider;
    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        //audioManager = GameObject.FindObjectOfType<AudioManager>().GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        audioManager.SetVolume("BackGround",volumeSlider.value);
        print(PlayerPrefsManager.GetDifficulty());
    }
    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);

    }
    public void SetDefault()
    {
        volumeSlider.value = 0.5f;
        difficultySlider.value = 0.5f;
    }
}
