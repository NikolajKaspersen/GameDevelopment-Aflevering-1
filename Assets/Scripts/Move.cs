using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    Vector3 startPos_player;
    public Transform transform_player;

    private void Awake()
    {
        startPos_player = transform_player.position;
    }

    void Update()
    {
        MoveLeftRight();
        MoveForward();
        //MoveRotation();
    }

    void MoveLeftRight()
    {

        //Todo: edit deltaTime * xx (change this value to edit speed)
        Vector3 vec_left = Vector3.zero;
        vec_left.x = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(vec_left.x, 0.0f, 0.0f) * Time.deltaTime * 10.0f;
        transform_player.Translate(v, Space.Self);
    }

    void MoveForward()
    {
        //Todo: edit deltaTime * xx (change this value to edit speed)
        Vector3 vec_forward = Vector3.zero;
        vec_forward.z = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(0.0f, 0.0f, vec_forward.z) * Time.deltaTime * 10.0f;
        transform_player.Translate(v, Space.Self);
    }

    void MoveRotation()
    {
       
        //Todo: edit deltaTime * xx (change this value to edit speed)
        //Todo:  for this to work you need to create the input to the input manager in unity
        //Top toolbar.. Edit > Project Settings > Input Manager > Dublicate one of the existing arrays and rename to "Rotate"
        Vector3 vec_rotate = Vector3.zero;
        vec_rotate.y = Input.GetAxis("Rotate");
        Vector3 v = new Vector3(0.0f, vec_rotate.y, 0.0f) * Time.deltaTime * 10.0f;
        transform_player.Rotate(v, Space.Self);
    }
}
