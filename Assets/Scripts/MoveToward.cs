using UnityEngine;

public class MoveToward : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 target = Vector3.zero;
    public Vector3 origin;
	private bool isMoving = false;
	void Start()
	{
		origin = transform.position;
	}

	// Update is called once per frame
	void Update()
    {
		if (Input.GetKeyDown(KeyCode.O))
		{
			isMoving = true;
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			isMoving = false;
			transform.position = origin;
		}
		if (isMoving)
			transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
	}
}
