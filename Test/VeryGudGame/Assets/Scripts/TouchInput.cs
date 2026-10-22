using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject PlayersTouch; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y));
                StartCoroutine(SpawnTouch());

            }
        }
    }

    IEnumerator SpawnTouch()
    {
        Instantiate(PlayersTouch, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }

}
