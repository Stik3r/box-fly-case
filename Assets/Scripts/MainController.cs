using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public GameObject cube;

    public GameObject inputSpeed;
    public GameObject inputTime;
    public GameObject inputDistance;


    float time = 1f;
    float timer;


    void Start()
    {
        timer = Time.fixedTime + time;
        inputSpeed.GetComponent<InputField>().onSubmit.AddListener(onSumbitInputSpeed);
        inputTime.GetComponent<InputField>().onSubmit.AddListener(onSumbitInputTime);
        inputDistance.GetComponent<InputField>().onSubmit.AddListener(onSumbitInputDistance);
    }

    void Update()
    {
        if (timer <= Time.time)
        {
            Instantiate(cube, transform.position, Quaternion.identity);
            timer = Time.time + time;
        }
    }

    public void onSumbitInputSpeed(string data)
    {
        if (float.TryParse(data, out float result))
        {
            CubeCotroller.speed = result;
        }
    }

    public void onSumbitInputTime(string data)
    {
        if (float.TryParse(data, out float result))
        {
            time = result;
        }
    }

    public void onSumbitInputDistance(string data)
    {
        if (float.TryParse(data, out float result))
        {
            CubeCotroller.distance = result;
        }
    }
}
