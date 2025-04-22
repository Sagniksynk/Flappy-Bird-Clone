using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax_effect : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField] private float parallex_speed=0.5f;
    private void Awake(){
        meshRenderer=GetComponent<MeshRenderer>();
    }

    private void Update(){
        meshRenderer.material.mainTextureOffset+=new Vector2(parallex_speed*Time.deltaTime,0f);
    }
}
