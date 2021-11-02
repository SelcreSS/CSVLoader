using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-20)]
public class GenelicSingleton<T> : Initializer where T : Initializer
{
	private static T _Instance;

	public static T Instance
	{
		get
		{
			//インスタンスがまだ作られていない
			if (_Instance == null)
			{
				_Instance = (T)FindObjectOfType(typeof(T));
				if (_Instance == null)
				{
					Debug.LogError(typeof(T) + " is nothing");
				}
				else
				{
					_Instance.InitIfNeeded();
				}
			}
			return _Instance;
		}
	}

	protected override void Awake()
	{
		if (this == Instance)
		{
			return;
		}
	}
}

public class Initializer : MonoBehaviour
{
	private bool _isInitialized = false;

	public void InitIfNeeded()
	{
		if (_isInitialized)
		{
			return;
		}
		Init();
		_isInitialized = true;
	}
	protected virtual void Awake() { }
	protected virtual void Start() { }
	protected virtual void Update() { }
	protected virtual void Init() { }
}