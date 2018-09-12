using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DiceUvMapper : MonoBehaviour
{
    [SerializeField]
    private Vector2[] uvMapp;

    private Mesh mesh;

    private Vector2[] diceMap;

	void Start ()
	{
	    mesh = GetComponent<MeshFilter>().mesh;

	    uvMapp = mesh.uv;

	    var third = 1f / 3f;
	    var twoThird = 2f / 3f;

	    List<Vector2> face = new List<Vector2>
        {
            new Vector2(0 , 0),
            new Vector2(0 , third),
            new Vector2(third , 0),

            new Vector2(third , 0),
            new Vector2(third , third),
            new Vector2(0 , third),
        };

        face.ForEach(x => Debug.Log(x));

	    Debug.Log("asdasd");

        face.Skip(1).Concat(face.Take(1)).ToList().ForEach(x => Debug.Log(x));

	    List<Vector2> list = new List<Vector2>();
        //1
        list.AddRange(face.Select(f => {
            f.x += twoThird;
            f.y += third;
            return f;
        }).ToList());

        //2
	    list.AddRange(face.Select(f => {
	        f.x += 0;
	        f.y += 0;
	        return f;
	    }).ToList());

        //3
	    list.AddRange(face.Select(f => {
	        f.x += third;
	        f.y += 0;
	        return f;
	    }).ToList());

        //4
	    list.AddRange(face.Select(f => {
	        f.x += 0;
	        f.y += third;
	        return f;
	    }).ToList());

        //5
	    list.AddRange(face.Select(f => {
	        f.x += twoThird;
	        f.y += 0;
	        return f;
	    }).ToList());

        //6
	    list.AddRange(face.Select(f => {
	        f.x += third;
	        f.y += third;
	        return f;
	    }).ToList());

	    mesh.uv = list.ToArray();
	}
}
