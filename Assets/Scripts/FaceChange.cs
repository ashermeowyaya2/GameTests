using UnityEngine;

public class FaceChange : MonoBehaviour
{
    public Material faceMaterial;
    public string Expression="";
    void Offset(Vector2 x){
        faceMaterial.SetVector("_Offset",x);
    }
    void ChangeFace(string exp){
        switch(exp){
            default:
                Offset(Vector2.zero);
                break;
            case "Sad":
                Offset(new Vector2(0.25f,0f));
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        ChangeFace(Expression);
    }
}
