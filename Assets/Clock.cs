using System; 
using UnityEngine; 


public class Clock : MonoBehaviour {
    [SerializeField] 
    Transform hoursPivot, minutePivot, secondPivot;

    void Start() {
        //Debug.Log("Clock started");
    }

    void Update() {
        Debug.Log(DateTime.Now);

        // 12 hours = 360 degrees on a clock, 360 / 12 = 30 degrees per hour
        // 60 mins = 360 degrees on a clock, 360 / 60 = 6 degrees per minute
        // 60 seconds = 360 degrees on a clock, 360 / 60 = 6 degrees per second

        // y axis the axis of rotation for the clock in my case 

        hoursPivot.localRotation = Quaternion.Euler(0, -360f / 12f * DateTime.Now.Hour, 0.0f * DateTime.Now.Hour);
        
        minutePivot.localRotation = Quaternion.Euler(0, -360f / 60f * DateTime.Now.Minute, 0.0f * DateTime.Now.Minute);

        secondPivot.localRotation = Quaternion.Euler(0, -360f / 60f * DateTime.Now.Second, 0.0f * DateTime.Now.Second);
    }
}