using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    private float _speed;
    private float _endPosY;

    public void StartFloating(float speed, float endPosY)
    {
        _speed = speed;
        _endPosY = endPosY;
    }

    void Update()
    {
        transform.Translate(Vector3.down * (Time.deltaTime * _speed));

        if (transform.position.y < _endPosY)
        {
            Destroy(gameObject);
        }
    }
}
