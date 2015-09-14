using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float m_score = 0;
	public float speed = 2f;
	private bool rotate = false;

	void Start()
	{
		rotate = false;
	}

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime * speed;

		if (rotate == true) 
		{
			transform.Rotate(0, 0, 1);
		}
    }

	/*public void UpdateScore()
	{
		m_score = m_score ++;
		print (m_score);
	}*/

	public void SlowPlayer()
	{
		speed = 1f;
	}

	public void RotatePlayer()
	{
		rotate = true;
	}
}
