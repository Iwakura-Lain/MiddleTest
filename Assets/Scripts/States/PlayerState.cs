﻿using System;
using UnityEngine;

public abstract class PlayerState : IDisposable
{
	public abstract void Update();

	public virtual void Start()
	{
		
	}

	public virtual void Dispose()
	{
		
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		
	}
}
