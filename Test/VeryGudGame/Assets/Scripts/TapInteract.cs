using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;

public class TapInteract : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Position pos;
    public GameObject SpawnItem;

    void Start()
    {
        pos = GameObject.FindWithTag("Player").GetComponent<Position>();
}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
          StartCoroutine(Pour());
           
        }
    }

    IEnumerator Pour()
    {
        Instantiate(SpawnItem, transform.position, Quaternion.identity);
        yield return pos;
    }
}
