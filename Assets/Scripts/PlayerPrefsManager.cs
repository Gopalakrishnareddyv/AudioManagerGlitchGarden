using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY="master_volume";
    const string DIFFICULTY_KEY="difficulty";
    const string LEVEL_KEY="level_difficulty_unlocked";
    
    
    
    public static void SetMasterVolume(float volume)
    {
        if(volume>0f&&volume<1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);

        }
        else
        {
            Debug.LogWarning("Volume out of range");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static void UnLockLevel(int level)
    {
        if (level <= SceneManager.sceneCountInBuildSettings-1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("This Level is not in build order");
        }
    }
    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool isLevelUnlocked = (levelValue == 1);
        if (level <= SceneManager.sceneCountInBuildSettings-1)
        {
            return isLevelUnlocked;
        }
        else
        {
            Debug.LogError("This Level is not in build order");
            return false;
        }

    }
    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= 0f && difficulty <= 1f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty out of range");
        }
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

    /*private void Start()
    {
        print(GetMasterVolume());
        SetMasterVolume(0.3f);
        print(GetMasterVolume());
        print(IsLevelUnlocked(2));
        UnLockLevel(2);
        print(IsLevelUnlocked(2));
        print(GetDifficulty());
        SetDifficulty(0.5f);
        print(GetDifficulty());

    }*/
}
