using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Vo;
    public float Distancia;
    public float g = 9.81f;

    Vector2 P;
    Vector2 V;
    Vector2 A;
    int click = 0;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        P = new Vector2(0, 5);
        V = new Vector2(Vo, 0);
        A = new Vector2(0, -g);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click = 1;
        }
        if(click == 1 && P.x < Distancia)
        {
            V.y = V.y + A.y * Time.deltaTime;
            time = time + Time.deltaTime;
            P.x = V.x * time;
            P.y = 5 + (0.5f)*A.y*Mathf.Pow(time, 2);
            transform.position = P;
            print("Posición: " + P);
            print("Velocidad: " + V);
            print("Tiempo: " + time);
            print("Caída vertical: " + (5 - P.y));
        }
    }
}
