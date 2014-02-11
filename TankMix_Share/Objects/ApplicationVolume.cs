using System;
using System.ComponentModel;
using System.Reflection;

namespace TankMix_Share
{
	public enum ApplicationVolumeUnit
	{
		Us_gpa,
		Imp_gpa,
		L_ha,
	}
	public class ApplicationVolume
	{
		// value for application volume
		public double value;
		// unit for application volume
		public ApplicationVolumeUnit unit;

		// three different units in application volume
		private double _Us_gpa;
		private double _Imp_gpa;
		private double _L_ha;
		// set and get for US gpa
		public double Us_gpa 
		{
			get
			{
				return _Us_gpa;
			}

			set
			{
				_Us_gpa = value;
			}
		}
		// set and get for Imp_gpa
		public double Imp_gpa
		{
			get
			{
				return _Imp_gpa; 
			}
			set
			{ 
				_Imp_gpa = value;
			}
		}
		// set and get for L/ha
		public double L_ha
		{
			get
			{
				return _L_ha;
			}

			set
			{ 
				_L_ha = value;
			}
		}

		// Constructor
		public ApplicationVolume ()
		{

		}

		// Set Value for this object
		public void SetValueAndUnit (ApplicationVolumeUnit u, double input) 
		{
			this.value = input;
			switch (u)
			{
			case ApplicationVolumeUnit.Us_gpa:
				this.unit = ApplicationVolumeUnit.Us_gpa;
				Us_gpa = input;
				Imp_gpa = CalculationManager.SharedInstance.Us_gpaToImp_gpa (input);
				L_ha = CalculationManager.SharedInstance.Us_gpaToL_ha (input);
				break;
			case ApplicationVolumeUnit.Imp_gpa:
				this.unit = ApplicationVolumeUnit.Imp_gpa;
				Imp_gpa = input;
				Us_gpa = CalculationManager.SharedInstance.Imp_gpaToUs_gpa (input);
				L_ha = CalculationManager.SharedInstance.Imp_gpaToL_ha (input);
				break;
			case ApplicationVolumeUnit.L_ha:
				this.unit = ApplicationVolumeUnit.L_ha;
				L_ha = input;
				Us_gpa = CalculationManager.SharedInstance.L_haToUs_gpa (input);
				Imp_gpa = CalculationManager.SharedInstance.L_haToImp_gpa (input);
				break;
			}

		}

		public void SetValue(double input)
		{
			this.value = input;
		}
	}
}


























