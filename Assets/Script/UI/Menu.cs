using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public Button btn;
    
    void Start()
    {
        btn.onClick.AddListener(() =>
        {
            menu.SetActive(true);
            Time.timeScale = 0;
        });
        menu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyBinding.menu))
        {
            bool next = !menu.activeSelf;
            menu.SetActive(next);

            Time.timeScale = next ? 0 : 1;
        }

    }
}
