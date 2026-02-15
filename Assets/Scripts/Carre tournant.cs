using UnityEngine;

public class Carretournant : MonoBehaviour
{
      public float vitesseRotationArbre = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(0f, 0f, vitesseRotationArbre * Time.deltaTime);
    }
}
