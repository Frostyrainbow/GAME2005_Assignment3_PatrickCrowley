using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControler : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.BackQuote))
        {
            panel.SetActive(!panel.activeInHierarchy);

            Cursor.lockState = (panel.activeInHierarchy) ? CursorLockMode.None : CursorLockMode.Locked;
        }

    }
}
