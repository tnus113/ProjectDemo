using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject cubeUp;
    public GameObject cubeDown;
    public GameObject cubeFoward;
    public GameObject cubeBack;
    public GameObject cubeLeft;
    public GameObject cubeRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeUp.transform.Rotate(Vector3.up);
        cubeDown.transform.Rotate(Vector3.down);
        cubeFoward.transform.Rotate(Vector3.forward);
        cubeBack.transform.Rotate(Vector3.back);
        cubeLeft.transform.Rotate(Vector3.left);
        cubeRight.transform.Rotate(Vector3.right);
	}
}
