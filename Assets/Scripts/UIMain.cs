using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using  UnityEditor;
#endif

public class UIMain : MonoBehaviour
{
    public static UIMain Instance;
    public TMP_Text foodName;
    public TMP_Text foodType;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void ToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void UpdateFoodInfo(string fName, string fType)
    {
        foodName.text = fName;
        foodType.text = fType;
    }

    public void ClearFoodInfo()
    {
        foodName.text = "";
        foodType.text = "";
    }

    // Update is called once per frame
    public void  Exit()
    {
       #if UNITY_EDITOR
       EditorApplication.ExitPlaymode();
       #else
       Application.Quit();
       #endif
    }
}
