﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

interface IMotionModel {
	void SetWaypoints(List<Vector3> newval);
	void MoveOrder(Vector3 goal);
}