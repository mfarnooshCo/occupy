﻿using System;
using System.Collections;

[Serializable]
public class UnitData : BaseObjectData{
	public String PlayerKey;
	public String Id;
	public int Type = -1;
	public int Level = 0;
	public String towerId = "";

	public double CurrentHitPoint = 0.0;

	public double Lat = 0.0;
	public double Lon = 0.0;


	public bool IsMoving = false;
	public bool IsAttacking = false;
	public bool IsUpgrading = false;
}
