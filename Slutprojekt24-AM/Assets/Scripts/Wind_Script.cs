using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wind_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public float displayedWindSpeed;
    public float displayedWindDirection;
    public float windDuration;

    void Start()
    {
        StartCoroutine(Wind());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int windSpeed, windDirection;
    IEnumerator Wind()
    {
        
        windDuration = Random.Range(10, 30);
        windSpeed = Random.Range(1, 40);
        windDirection = Random.Range(-180, 180);
        Debug.Log(("Windspeed is: " + windSpeed) +" "+ ("Wind direction is: " + windDirection));


        
        //changes the windspeed gradually to the target speed
        if (windSpeed != displayedWindSpeed)
        {
            if (displayedWindSpeed != windSpeed)
            {
                for(int i = 0; i  < windSpeed; i++)
                {
                    displayedWindSpeed++;
                    Debug.Log("started wait");
                    yield return new WaitForSeconds(0.5f);
                    Debug.Log("endend wait");
                }
                
            }
            else if (displayedWindSpeed == windSpeed)
            {
                for (int i = 0; i > windSpeed; i--)
                {
                    displayedWindSpeed--;
                    yield return new WaitForSeconds(0.5f);
                }
            }
            else
            {
                Debug.Log("There is no difference");
            }
            Debug.Log("changing windspeed");
        }

        //changes the winddirection gradually to the target direction, also no work :(
        if (windDirection != displayedWindDirection)
        {
            Debug.Log("Windirection is not equal to displayed");
            for (int i=0; i==(windDirection-displayedWindDirection);)
            {
                if (windDirection - displayedWindDirection > 0)
                {
                    displayedWindDirection++;
                    i++;
                }
                else if (windDirection - displayedWindDirection < 0)
                {
                    displayedWindDirection--;
                    i--;
                }
                else
                {
                    Debug.Log("There is no difference");
                }

                
                

            }
            Debug.Log("changing windDirection");
            yield return new WaitForSeconds(0.5f);
        }

        Debug.Log("New wind direction is" + windDirection);
        Debug.Log("New wind speed is" + windSpeed);


        yield return new WaitForSeconds(windDuration);
        Debug.Log("Wind has Waited");
        yield return StartCoroutine(Wind());
        Debug.Log("Coroutine restarted");


    }

    IEnumerator Wait()
    {
        Debug.Log("Is Waiting");
        yield return new WaitForSeconds(0.5f);
        displayedWindSpeed--;
    }
}
