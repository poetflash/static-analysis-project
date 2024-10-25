using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppEntryPoint : MonoBehaviour
{
    [SerializeField] private GameObject _type;
    [SerializeField] private Button Button;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Button.onClick.AddListener(
		        () =>
        {
	        _type.SetActive(true); 
	        
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
