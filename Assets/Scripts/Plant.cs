using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private GameObject Cauldron; 
    [SerializeField] private GameObject spicy; 
    [SerializeField] private GameObject leaf; 
    [SerializeField]  private GameObject knife; //referancing knife is subject to change
    Coroutine myCR;
    Renderer plantObj;
    Renderer spicyObj;
    Renderer leafObj;
    Renderer cauldronObj;
    Transform defaultPlace;

    public bool executed = false;
    float oldScale = 1f;
    float currentScale = 1f;

    
    private void Start(){
        Renderer[] plantArray = this.GetComponentsInChildren<Renderer>();
        this.plantObj = plantArray[0];
        this.defaultPlace = plantObj.transform;
        
        Renderer[] spicyArray = spicy.GetComponentsInChildren<Renderer>();
        this.spicyObj = spicyArray[0];
        this.spicyObj.enabled = false;

        Renderer[] leafArray = leaf.GetComponentsInChildren<Renderer>();
        this.leafObj = leafArray[0];
        this.leafObj.enabled = false;

        Renderer[] cauldronArray = Cauldron.GetComponentsInChildren<Renderer>();
        this.cauldronObj = cauldronArray[0];
    }

    public void VisiblePlant(){
        this.plantObj.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
        this.plantObj.transform.position = defaultPlace.position;
        this.plantObj.enabled = true;
        this.spicyObj.enabled = false;
        this.leafObj.enabled = false;
    }
    public void Grind()
    {
        this.executed = true;

        this.plantObj.enabled = false;
        this.spicyObj.enabled = true;

        myCR =  StartCoroutine (MoveToCauldron(this.spicyObj.transform)); 
        
    }

    private IEnumerator MoveToCauldron (Transform transform)
    {
        Vector3 startingPos  = transform.position;
        Vector3 finalPos = new Vector3(0, 0.80f, 0);
        float time = 1f;
        float elapsedTime = 0; 

        while (elapsedTime < time && startingPos != finalPos)
        {
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    public void Grow()
    {   
        Transform plantTransform = this.plantObj.transform;
        Debug.Log(oldScale);
        this.oldScale = plantTransform.transform.localScale.x;
        Debug.Log(oldScale);
        plantTransform.transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
        this.currentScale = plantTransform.transform.localScale.x;
    }

    public float GetOldScale()
    {   
        return this.oldScale;
    }

    public Renderer GetPlantObj()
    {   
        return this.plantObj;
    }

    private IEnumerator SmoothLerp (Transform transform, Transform target, float time)
    {
        Vector3 startingPos  = transform.position;
        Vector3 finalPos = target.position;
        float elapsedTime = 0; 

        while (elapsedTime < time && startingPos != finalPos)
        {
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
            
        }

        yield return new WaitForSeconds(0.5f);
        this.plantObj.enabled = false;
        this.leafObj.enabled = true;
    
        elapsedTime = 0;
        while (elapsedTime < time && startingPos != finalPos)
        {
            transform.position = Vector3.Lerp(finalPos, startingPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        startingPos  = this.leafObj.transform.position;
        finalPos = new Vector3(0, 0.80f, 0);
        elapsedTime = 0; 

        while (elapsedTime < time && startingPos != finalPos)
        {
            this.leafObj.transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
            
        }
        
    }

    public void Chop()
    {
        this.executed = true;
        Transform plantTransform = this.plantObj.transform;
        Transform knifeTransform = knife.GetComponent<Renderer>().transform;
        
        myCR =  StartCoroutine (SmoothLerp (knifeTransform, plantTransform, 1f)); 

    }

    


}
