using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch; //To avoid errors

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public AudioSource tapPouring;
    public AudioClip PourSound;

    private void Awake()
    {
        tapPouring = GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }

    protected void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch taptouch in Touch.activeTouches)
        {
            if (taptouch.isTap) //If the dectected touch is a tap
            {
                tapPouring.PlayOneShot(PourSound);

                Debug.Log("Imma Touch the Tap");
            }
            break;
        }
        
    }


}
