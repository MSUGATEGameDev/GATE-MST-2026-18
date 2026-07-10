using JetBrains.Annotations;
using UnityEngine;

public class Sanity : MonoBehaviour
{ 
    public float sanity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sanity = sanity - (50 * Time.deltaTime);
        HUD.DisplayNotice("Sanity: " + sanity.ToString()); 
        if (sanity <= 75)
        {
            HUD.DisplayNotice("you did it!you didn't think there was anything nefarious did you? that's dumb. all you had to do was survive. anyways, you won, congrats :3");
        }
        else
        {

        }
    }
        
        
}
