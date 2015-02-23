using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
	public GameObject player;
	private Vector3 _offset;
	
	public void Start()
	{
		_offset = transform.position - player.transform.position;

		_offset.x += 16.0f;
		_offset.y += 2.0f;
	}
	
	public void Update()
	{
		transform.position = player.transform.position + _offset;
	}
}
