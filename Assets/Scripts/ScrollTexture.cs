using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public Material material;

    private void Start()
    {
        material.mainTextureOffset = new Vector2();
    }

    void Update ()
	{
	    material.mainTextureOffset += new Vector2(0.1f * Time.deltaTime, 0);

	    if (Input.GetKeyUp(KeyCode.A))
	    {
	        switch (material.mainTexture.wrapMode)
	        {
	            case TextureWrapMode.Clamp:
	                material.mainTexture.wrapMode = TextureWrapMode.Mirror;
                    Debug.Log(TextureWrapMode.Mirror);
	                break;
	            case TextureWrapMode.Mirror:
	                material.mainTexture.wrapMode = TextureWrapMode.MirrorOnce;
	                Debug.Log(TextureWrapMode.MirrorOnce);
                    break;
	            case TextureWrapMode.MirrorOnce:
	                material.mainTexture.wrapMode = TextureWrapMode.Repeat;
	                Debug.Log(TextureWrapMode.Repeat);
                    break;
	            case TextureWrapMode.Repeat:
	                material.mainTexture.wrapMode = TextureWrapMode.Clamp;
	                Debug.Log(TextureWrapMode.Clamp);
                    break;
	            default:
	                material.mainTexture.wrapMode = TextureWrapMode.Mirror;
	                break;
	        }
	    }

	    if (Input.GetKeyUp(KeyCode.S))
	    {

	    }

	    //        material.mainTexture.wrapMode = 
            //        material.mainTexture.filterMode = 
            //	    material.mainTexture.anisoLevel = 

        }
}
