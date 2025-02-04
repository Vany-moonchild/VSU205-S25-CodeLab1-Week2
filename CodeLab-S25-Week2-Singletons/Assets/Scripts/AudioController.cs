using UnityEngine;

public class AudioController : MonoBehaviour
{
    
    
    
    public static AudioController instance;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //check to see if someone has set the instance
        if (instance == null)
        {
            //if they haven't 
            instance = this;
            DontDestroyOnLoad(this);
        }
        else //otherwise, if there is an existing instance
        {
            //destroy the new instance that was created
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
