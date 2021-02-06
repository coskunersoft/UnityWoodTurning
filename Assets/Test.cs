using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Test : MonoBehaviour
{
    public static Test Instance;

    public GameObject WoodReal;
    public GameObject WoodVisual;
    public Texture MatSecond;


    public float WoodMachineRotationSpeed;
    public Transform WoodMachine;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
       
        Generate();
    }
    void Generate()
    {
        Vector3 start = Vector3.zero;

        for (int i = 0; i < 400; i++)
        {
            GameObject createdVisual = Instantiate(WoodVisual, start, Quaternion.Euler(0, 0, 90));
            GameObject created = Instantiate(WoodReal, start, Quaternion.Euler(0, 0, 90));
            created.GetComponent<Wood>().VisualObject = createdVisual.transform;
            start.x += created.transform.localScale.y;
            createdVisual.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(0,(i * (1f / 400f)));
            createdVisual.transform.SetParent(WoodMachine);
        }
        start = Vector3.zero;
        for (int i = 0; i < 400; i++)
        {
            GameObject createdVisual = Instantiate(WoodVisual, start, Quaternion.Euler(0, 0, 90));
            GameObject created = Instantiate(WoodReal, start, Quaternion.Euler(0, 0, 90));
            created.GetComponent<Wood>().VisualObject = createdVisual.transform;
            start.x -= created.transform.localScale.y;
            createdVisual.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(0, (i * (1f / 400f)));
            createdVisual.transform.SetParent(WoodMachine);
        }
    }

    public void Update()
    {
        WoodMachine.transform.Rotate(new Vector3(10,0,0)*Time.deltaTime*WoodMachineRotationSpeed);
    }

    
}
