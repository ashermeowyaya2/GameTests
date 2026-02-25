using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complexFaceChange : MonoBehaviour
{
    public Material _faceMaterial;
    public int Eyebrows;
    public int Eyes;
    public int EyeShape;
    //private Texture[] EyeShapes = {_cattyEyes,_bunnyEyes};
    public int Mouth;
    private string ebOffset="_OffsetEyebrows";
    private string eOffset="_OffsetEyes";
    private string mOffset="_OffsetMouth";
    void Offset(string x,Vector2 y){
        _faceMaterial.SetVector(x,y);
    }
    public void ChangeEyebrows(int exp){
        switch(exp){
            default:
                Offset(ebOffset,Vector2.zero);
                break;
            case 1:
                Offset(ebOffset,new Vector2(0.25f,0f));
                break;
            case 2:
                Offset(ebOffset,new Vector2(0.5f,0f));
                break;
            case 3:
                Offset(ebOffset,new Vector2(0.75f,0f));
                break;
            case 4:
                Offset(ebOffset,new Vector2(0.0f,-0.25f));
                break;
            case 5:
                Offset(ebOffset,new Vector2(0.25f,-0.25f));
                break;
            case 6:
                Offset(ebOffset,new Vector2(0.5f,-0.25f));
                break;
            case 7:
                Offset(ebOffset,new Vector2(0.75f,-0.25f));
                break;
        }
    }
    public void ChangeEyes(int exp){
        switch(exp){
            default:
                Offset(eOffset,Vector2.zero);
                break;
            case 1:
                Offset(eOffset,new Vector2(0.25f,0f));
                break;
            case 2:
                Offset(eOffset,new Vector2(0.5f,0f));
                break;
            case 3:
                Offset(eOffset,new Vector2(0.75f,0f));
                break;
            case 4:
                Offset(eOffset,new Vector2(0.0f,-0.25f));
                break;
            case 5:
                Offset(eOffset,new Vector2(0.25f,-0.25f));
                break;
            case 6:
                Offset(eOffset,new Vector2(0.5f,-0.25f));
                break;
            case 7:
                Offset(eOffset,new Vector2(0.75f,-0.25f));
                break;
        }
    }
    public void ChangeMouth(int exp){
        switch(exp){
            default:
                Offset(mOffset,Vector2.zero);
                break;
            case 1:
                Offset(mOffset,new Vector2(0.25f,0f));
                break;
            case 2:
                Offset(mOffset,new Vector2(0.5f,0f));
                break;
            case 3:
                Offset(mOffset,new Vector2(0.75f,0f));
                break;
            case 4:
                Offset(mOffset,new Vector2(0.0f,-0.25f));
                break;
            case 5:
                Offset(mOffset,new Vector2(0.25f,-0.25f));
                break;
            case 6:
                Offset(mOffset,new Vector2(0.5f,-0.25f));
                break;
            case 7:
                Offset(mOffset,new Vector2(0.75f,-0.25f));
                break;
        }
    }
    public void ResetFace(){
        Offset(ebOffset,Vector2.zero);
        Offset(eOffset,Vector2.zero);
        Offset(mOffset,Vector2.zero);
    }
    public Texture _cattyEyeLash;
    public Texture _cattyEyeSclera;
    public Texture _bunnyEyeLash;
    public Texture _bunnyEyeSclera;
    public Texture _boredEyeLash;
    public Texture _boredEyeSclera;
    public void ChangeEyeShape(int x){
        switch(x){
            case 1: // Catty Eyes
                _faceMaterial.SetTexture("_EyesLashes",_cattyEyeLash);
                _faceMaterial.SetTexture("_EyesSclera",_cattyEyeSclera);
                break;
            case 2: // Bunny Eyes
                _faceMaterial.SetTexture("_EyesLashes",_bunnyEyeLash);
                _faceMaterial.SetTexture("_EyesSclera",_bunnyEyeSclera);
                break;
            case 3: // Bored Eyes
                _faceMaterial.SetTexture("_EyesLashes",_boredEyeLash);
                _faceMaterial.SetTexture("_EyesSclera",_boredEyeSclera);
                break;
            default:
                _faceMaterial.SetTexture("_EyesLashes",_cattyEyeLash);
                _faceMaterial.SetTexture("_EyesSclera",_cattyEyeSclera);
                break;
        }
    }
}
