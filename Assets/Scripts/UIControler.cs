using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour
{
    [Header("UI Controls")]
    public GameObject panel;
    public Toggle gravityCheckbox;
    public Slider gravityScaleSlider;
    public Text gravityScaleValueText;
    public Text currentScaleText;
    public PhysicsManager physicManager;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        gravityScaleValueText.text = gravityScaleSlider.value.ToString();
        physicManager = FindObjectOfType<PhysicsManager>(); // return the first found component in the scene which has the type
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

    public void OnOKButtonPressed()
    {
        Debug.Log("Button Pressed");
        panel.SetActive(!panel.activeInHierarchy);

        Cursor.lockState = (panel.activeInHierarchy) ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public void OnGravityToggled()
    {
        Debug.Log("Gravity has been toggled");

        if (gravityCheckbox.isOn)
        {
            Debug.Log("Gravity is on");
            physicManager.gravity.y = physicManager.gravityScale;
        }
        else
        {
            Debug.Log("Gravity is off");
            physicManager.gravity.y = 0;
        }
    }

    public void OnGravityScaleValueChange()
    {
        gravityScaleValueText.text = gravityScaleSlider.value.ToString();
        physicManager.gravityScale = gravityScaleSlider.value;
        physicManager.gravity.y = physicManager.gravityScale;
        currentScaleText.text = physicManager.gravityScale.ToString();

    }
}
