using Unity.VisualScripting;
using UnityEngine;

public class IconBehavior : MonoBehaviour
{
    public GameObject[] icons;
    private float time;
    int icon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = 0.0f;
        icon = 0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
