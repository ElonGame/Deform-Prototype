﻿using UnityEngine;
using Unity.Jobs;
using Deform.Data;

namespace Deform
{
	[RequireComponent (typeof (DeformerObject))]
	public abstract class Deformer : MonoBehaviour
	{
		protected const int BATCH_COUNT = 100;

		public abstract JobHandle Deform (NativeMeshData data, JobHandle dependency);
	}
}