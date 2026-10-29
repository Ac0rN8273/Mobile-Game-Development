using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    AudioSource tapPouring;

    private void Awake()
    {
        tapPouring = GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        tapPouring.Play();
    }
}
