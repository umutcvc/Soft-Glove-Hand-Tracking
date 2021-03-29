using System.Collections;
using UnityEngine;
using System.IO.Ports;
public class Test : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM3",9600); // PORTLARIN DATA AKTARMASINI BASLATIYOR
    public string receivedstring;
    public float sensitivity = 0.001f;
    public Transform b_r_index3, b_r_index2, b_r_index1;
    public string[] datas;
    void Start()
    {
        data_stream.Open();
    }
    void Update()
    {
        receivedstring = data_stream.ReadLine();
        int received_angle = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_2 = Mathf.RoundToInt(float.Parse(receivedstring));
        int received_angle_3 = Mathf.RoundToInt(float.Parse(receivedstring));
        b_r_index1.transform.localEulerAngles = new Vector3(0,0,(-received_angle*0.005f)*0.5f);
        b_r_index2.transform.localEulerAngles = new Vector3(0,0,(-received_angle_2*0.005f)*1f);
        b_r_index3.transform.localEulerAngles = new Vector3(0,0,(-received_angle_3*0.005f)*1.5f);
    }
}
