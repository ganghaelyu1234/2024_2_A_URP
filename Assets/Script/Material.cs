using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{
    public Material material;
    public float amount = -1;
    public bool bDisslove;

    private void Start()
    {
        amount = -1;
        material.SetFolat("_Amount", amount);

    }

    private void Update()
    {
        if(bDisslove)
        {
            amount += Time.deltaTime;
            material.SetFloat("_Amount", amount);
        }
    }

}
