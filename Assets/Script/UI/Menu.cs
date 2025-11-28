using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public Button btn;
    
    void Start()
    {
        btn.onClick.AddListener(Activetrue);
        Activefalse();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            if(menu.activeSelf)
            {
                Activefalse();
                Debug.Log("False");
            }
            else
            {
                Debug.Log("True");
                Activetrue();
            }
        }
    }
    public void Activetrue()
    {
        menu.SetActive(true);
    }

    public void Activefalse()
    {
        menu.SetActive(false);
    }

}
