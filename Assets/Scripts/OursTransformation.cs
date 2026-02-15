using UnityEngine;

public class OursTransformation : MonoBehaviour
{
    public float VitesseHexagon;
    public float RotationHexagon = 45f;
 
    private float LimiteHautY = 15f;
    private float LimiteBasY = -15f;
 
    private float PositionDepartY;
 
    private bool Hauteur = true;

    public float VitesseEchelle = 2f;
    private bool Agrandissement = true;

    public float EchelleMax = 4f;
    public float EchelleMin = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PositionDepartY = transform.position.y;
 
        Hauteur = PositionDepartY > 0;
 
        VitesseHexagon = Random.Range(1f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
                if (Hauteur == true)
        {
            transform.position += new Vector3(0f, -VitesseHexagon * Time.deltaTime, 0f);
 
            if (transform.position.y <= LimiteBasY)
        {
                transform.position = new Vector3(transform.position.x, PositionDepartY, transform.position.z);
                VitesseHexagon = Random.Range(1f, 10f);
            }
        }
 
        if (Hauteur == false)
        {
            transform.position += new Vector3(0f, VitesseHexagon * Time.deltaTime, 0f);
 
            if (transform.position.y >= LimiteHautY)
            {
                transform.position = new Vector3(transform.position.x, PositionDepartY, transform.position.z);
                VitesseHexagon = Random.Range(1f, 10f);
            }
        }
        transform.Rotate(0f, 0f, RotationHexagon * Time.deltaTime);

        if (Agrandissement == true) {
            transform.localScale += Vector3.one * VitesseEchelle * Time.deltaTime;

            if (EchelleMax < transform.localScale.x) {
                Agrandissement = false;
            }
        }
        else if (Agrandissement == false) {
            transform.localScale += Vector3.one * -VitesseEchelle * Time.deltaTime;

            if (EchelleMin > transform.localScale.x) {
                Agrandissement = true;
            }
        }
    }
}
