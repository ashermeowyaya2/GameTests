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
            case "1":
                Offset(new Vector2(0.25f,0f));
                break;
            case "2":
                Offset(new Vector2(0.5f,0f));
                break;
            case "3":
                Offset(new Vector2(0.75f,0f));
                break;
            case "4":
                Offset(new Vector2(0.0f,-0.25f));
                break;
            case "5":
                Offset(new Vector2(0.25f,-0.25f));
                break;
            case "6":
                Offset(new Vector2(0.5f,-0.25f));
                break;
            case "7":
                Offset(new Vector2(0.75f,-0.25f));
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        ChangeFace(Expression);
    }
}
