using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField countIN;
    [SerializeField]
    private TMP_InputField sizeIN;
    public static float count;
    public static float size;
    [SerializeField]
    private GameObject ball;
    private Vector3 mousePos;
    public static int subCount;
    [SerializeField]
    private TMP_Dropdown tmpcolour;
    public static int ballcolour;
    public static float[] myRandom;
    private float rand1;
    private float rand2;
    private float rand3;
    private float randRatio;
    // Update is called once per frame
    void Update()
    {
        size = float.Parse(sizeIN.text);
        count = float.Parse(countIN.text);

        mousePos = Input.mousePosition;
        mousePos.z = 0;
        if (Input.GetMouseButtonDown(0) && Camera.main.ScreenToWorldPoint(mousePos).y < 2.65)
        {
            subCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (ballcolour == 4)
                {
                    SetRandom();
                }
                Instantiate(ball, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);
                subCount++;
            }
        }
        ballcolour = tmpcolour.value;
    }
    private void Start()
    {
        sizeIN.text = 1.ToString();
        countIN.text = 1.ToString();
        myRandom = new float[3];
    }
    private void SetRandom()
    {
        rand1 = Random.Range(0f, 1f);
        rand2 = Random.Range(0f, 1f);
        rand3 = Random.Range(0f, 1f);
        randRatio = 1/Mathf.Max(rand1,rand2,rand3);
        myRandom[0] = rand1 * randRatio;
        myRandom[1] = rand2 * randRatio;
        myRandom[2] = rand3 * randRatio;
    }
}
