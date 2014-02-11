using System;

namespace TankMix_Share
{
	interface ICalculationManager
	{
		double Us_gpaToImp_gpa(double input);
		double Us_gpaToL_ha(double input);
		double Imp_gpaToUs_gpa (double input);
		double Imp_gpaToL_ha (double input);
		double L_haToUs_gpa (double input);
		double L_haToImp_gpa (double input);

		double Acres_caseToL_acre(double input);
		double Acres_caseToG_acre(double input);
		double Acres_caseToMl_acre(double input);
		double Acres_caseToUs_fl_oz_acre(double input);
		double Acres_caseToUs_pint_acre(double input);
		double Acres_caseToUs_quart_acre(double input);
		double Acres_caseToOz_acre(double input);
		double Acres_caseToL_ha(double input);
		double Acres_caseToG_ha(double input);
		double Acres_caseToMl_ha(double input);

		double L_acreToAcres_case(double input);
		double L_acreToG_acre(double input);
		double L_acreToMl_acre(double input);
		double L_acreToUs_fl_oz_acre(double input);
		double L_acreToUs_pint_acre(double input);
		double L_acreToUs_quart_acre(double input);
		double L_acreToOz_acre(double input);
		double L_acreToL_ha(double input);
		double L_acreToG_ha(double input);
		double L_acreToMl_ha(double input);

		double G_acreToAcres_case(double input);
		double G_acreToL_acre(double input);
		double G_acreToMl_acre(double input);
		double G_acreToUs_fl_oz_acre(double input);
		double G_acreToUs_pint_acre(double input);
		double G_acreToUs_quart_acre(double input);
		double G_acreToOz_acre(double input);
		double G_acreToL_ha(double input);
		double G_acreToG_ha(double input);
		double G_acreToMl_ha(double input);

		double Ml_acreToAcres_case(double input);
		double Ml_acreToL_acre(double input);
		double Ml_acreToG_acre(double input);
		double Ml_acreToUs_fl_oz_acre(double input);
		double Ml_acreToUs_pint_acre(double input);
		double Ml_acreToUs_quart_acre(double input);
		double Ml_acreToOz_acre(double input);
		double Ml_acreToL_ha(double input);
		double Ml_acreToG_ha(double input);
		double Ml_acreToMl_ha(double input);

		double Us_fl_oz_acreToAcres_case(double input);
		double Us_fl_oz_acreToL_acre(double input);
		double Us_fl_oz_acreToG_acre(double input);
		double Us_fl_oz_acreToMl_acre(double input);
		double Us_fl_oz_acreToUs_pint_acre(double input);
		double Us_fl_oz_acreToUs_quart_acre(double input);
		double Us_fl_oz_acreToOz_acre(double input);
		double Us_fl_oz_acreToL_ha(double input);
		double Us_fl_oz_acreToG_ha(double input);
		double Us_fl_oz_acreToMl_ha(double input);

		double Us_pint_acreToAcres_case(double input);
		double Us_pint_acreToL_acre(double input);
		double Us_pint_acreToG_acre(double input);
		double Us_pint_acreToMl_acre(double input);
		double Us_pint_acreToUs_fl_oz_acre(double input);
		double Us_pint_acreToUs_quart_acre(double input);
		double Us_pint_acreToOz_acre(double input);
		double Us_pint_acreToL_ha(double input);
		double Us_pint_acreToG_ha(double input);
		double Us_pint_acreToMl_ha(double input);

		double Us_quart_acreToAcres_case(double input);
		double Us_quart_acreToL_acre(double input);
		double Us_quart_acreToG_acre(double input);
		double Us_quart_acreToMl_acre(double input);
		double Us_quart_acreToUs_fl_oz_acre(double input);
		double Us_quart_acreToUs_pint_acre(double input);
		double Us_quart_acreToOz_acre(double input);
		double Us_quart_acreToL_ha(double input);
		double Us_quart_acreToG_ha(double input);
		double Us_quart_acreToMl_ha(double input);

		double Oz_acreToAcres_case(double input);
		double Oz_acreToL_acre(double input);
		double Oz_acreToG_acre(double input);
		double Oz_acreToMl_acre(double input);
		double Oz_acreToUs_fl_oz_acre(double input);
		double Oz_acreToUs_pint_acre(double input);
		double Oz_acreToUs_quart_acre(double input);
		double Oz_acreToL_ha(double input);
		double Oz_acreToG_ha(double input);
		double Oz_acreToMl_ha(double input);

		double L_haToAcres_case(double input);
		double L_haToL_acre(double input);
		double L_haToG_acre(double input);
		double L_haToMl_acre(double input);
		double L_haToUs_fl_oz_acre(double input);
		double L_haToUs_pint_acre(double input);
		double L_haToUs_quart_acre(double input);
		double L_haToOz_acre(double input);
		double L_haToG_ha(double input);
		double L_haToMl_ha(double input);

		double G_haToAcres_case(double input);
		double G_haToL_acre(double input);
		double G_haToG_acre(double input);
		double G_haToMl_acre(double input);
		double G_haToUs_fl_oz_acre(double input);
		double G_haToUs_pint_acre(double input);
		double G_haToUs_quart_acre(double input);
		double G_haToOz_acre(double input);
		double G_haToL_ha(double input);
		double G_haToMl_ha(double input);

		double Ml_haToAcres_case(double input);
		double Ml_haToL_acre(double input);
		double Ml_haToG_acre(double input);
		double Ml_haToMl_acre(double input);
		double Ml_haToUs_fl_oz_acre(double input);
		double Ml_haToUs_pint_acre(double input);
		double Ml_haToUs_quart_acre(double input);
		double Ml_haToOz_acre(double input);
		double Ml_haToL_ha(double input);
		double Ml_haToG_ha(double input);

		double V_vToL_acre(double input);
		double V_vToMl_acre(double input);
		double V_vToUs_fl_oz_acre(double input);
		double V_vToQuart_acre(double input);

		double Us_galToImp_gal(double input);
		double Us_galToL(double input);

		double LToImp_gal(double input);
		double LToUs_gal(double input);

		double Imp_galToL(double input);
		double Imp_galToUs_gal(double input);

		double AcresToHa (double input);
		double HaToAcres (double input);

		double MToFt(double input);
		double FtToM(double input);

		double MileToM(double input);
		double MToMile(double input);

		// Calculation For Results
		double NetTankVolume ();


	}
	public class CalculationManager : ICalculationManager
	{
		// use Singleton Patern to create shared CalculationManager
		private static CalculationManager sharedInstance;
		private CalculationManager ()
		{
		}
		public static CalculationManager SharedInstance
		{
			get 
			{
				if(sharedInstance == null)
				{
					sharedInstance = new CalculationManager ();
				}
				return sharedInstance;
			}
		}

		#region ICalculationManager implementation

		public double Us_gpaToImp_gpa (double input)
		{
			return input * 0.832674;
		}

		public double Us_gpaToL_ha (double input)
		{
			return input * 9.35395623;
		}

		public double Imp_gpaToUs_gpa (double input)
		{
			return input * 1.20095042;
		}

		public double Imp_gpaToL_ha (double input)
		{
			return input * 11.2336377;
		}

		public double L_haToUs_gpa (double input)
		{
			return input * 0.106906637;
		}

		public double L_haToImp_gpa (double input)
		{
			return input * 0.0890183597;
		}

		public double Acres_caseToL_acre(double input){return 0.0;}
		public double Acres_caseToG_acre(double input){return 0.0;}
		public double Acres_caseToMl_acre(double input){return 0.0;}
		public double Acres_caseToUs_fl_oz_acre(double input){return 0.0;}
		public double Acres_caseToUs_pint_acre(double input){return 0.0;}
		public double Acres_caseToUs_quart_acre(double input){return 0.0;}
		public double Acres_caseToOz_acre(double input){return 0.0;}
		public double Acres_caseToL_ha(double input){return 0.0;}
		public double Acres_caseToG_ha(double input){return 0.0;}
		public double Acres_caseToMl_ha(double input){return 0.0;}


		public double L_acreToAcres_case(double input){return 0.0;}
		public double L_acreToG_acre(double input)
		{
			return input * 0.264172;
		}
		public double L_acreToMl_acre(double input)
		{
			return input * 1000;
		}
		public double L_acreToUs_fl_oz_acre(double input)
		{
			// 1 fl oz = 29.57 ml
			return L_acreToMl_acre(input) / 29.57;
		}
		public double L_acreToUs_pint_acre(double input)
		{
			return input * 2.11338;
		}
		public double L_acreToUs_quart_acre(double input)
		{
			return input * 1.05669;
		}
		public double L_acreToOz_acre(double input)
		{
			return input * 33.814;
		}
		public double L_acreToL_ha(double input)
		{
			return input * 2.471053811;
		}
		public double L_acreToG_ha(double input)
		{
			return L_acreToL_ha(input) * 0.26417;
		}
		public double L_acreToMl_ha(double input)
		{
			return L_acreToL_ha(input) * 1000;
		}
		public double G_acreToAcres_case(double input){return 0.0;}
		public double G_acreToL_acre(double input)
		{
			return input * 3.78541;
		}
		public double G_acreToMl_acre(double input)
		{
			return input * 3785.41;
		}
		public double G_acreToUs_fl_oz_acre(double input)
		{
			return G_acreToMl_acre (input) / 29.57;
		}
		public double G_acreToUs_pint_acre(double input)
		{
			return input * 8;
		}
		public double G_acreToUs_quart_acre(double input)
		{
			return input * 4;
		}
		public double G_acreToOz_acre(double input)
		{
			return input * 128;
		}
		public double G_acreToL_ha(double input)
		{
			return G_acreToG_ha (input) * 3.78541;
		}
		public double G_acreToG_ha(double input)
		{
			return input * 2.47105381;
		}
		public double G_acreToMl_ha(double input)
		{
			return G_acreToG_ha (input) * 3785.41;
		}

		public double Ml_acreToAcres_case(double input){return 0.0;}
		public double Ml_acreToL_acre(double input)
		{
			return input * 0.001;
		}
		public double Ml_acreToG_acre(double input)
		{
			return input * 0.000264172;
		}
		public double Ml_acreToUs_fl_oz_acre(double input)
		{
			return input / 29.57;
		}
		public double Ml_acreToUs_pint_acre(double input)
		{
			return input * 0.00211338;
		}
		public double Ml_acreToUs_quart_acre(double input)
		{
			return input * 0.00105669;
		}
		public double Ml_acreToOz_acre(double input)
		{
			return input * 0.033814;
		}
		public double Ml_acreToL_ha(double input)
		{
			return Ml_acreToMl_ha (input) * 0.0001;
		}
		public double Ml_acreToG_ha(double input)
		{
			return Ml_acreToMl_ha (input) * 0.000264172;
		}
		public double Ml_acreToMl_ha(double input)
		{
			return input * 2.47105381;
		}

		public double Us_fl_oz_acreToAcres_case(double input){return 0.0;}
		public double Us_fl_oz_acreToL_acre(double input)
		{
			return Us_fl_oz_acreToMl_acre (input) * 0.001;
		}
		public double Us_fl_oz_acreToG_acre(double input)
		{
			return Us_fl_oz_acreToMl_acre (input) * 0.000264172;
		}
		public double Us_fl_oz_acreToMl_acre(double input)
		{
			return input * 29.57;
		}
		public double Us_fl_oz_acreToUs_pint_acre(double input)
		{
			return Us_fl_oz_acreToMl_acre (input) * 0.00211338;
		}
		public double Us_fl_oz_acreToUs_quart_acre(double input)
		{
			return Us_fl_oz_acreToMl_acre (input) * 0.00105669;
		}
		public double Us_fl_oz_acreToOz_acre(double input)
		{
			return Us_fl_oz_acreToMl_acre (input) * 0.033814;
		}
		public double Us_fl_oz_acreToL_ha(double input)
		{
			return Us_fl_oz_acreToMl_ha (input) * 0.001;
		}
		public double Us_fl_oz_acreToG_ha(double input)
		{
			return Us_fl_oz_acreToMl_ha (input) * 0.000264172;
		}
		public double Us_fl_oz_acreToMl_ha(double input)
		{
			return  Us_fl_oz_acreToMl_acre (input) * 2.47105381;
		}

		public double Us_pint_acreToAcres_case(double input){return 0.0;}
		public double Us_pint_acreToL_acre(double input)
		{
			return input * 0.473176;
		}
		public double Us_pint_acreToG_acre(double input)
		{
			return input * 0.125;
		}
		public double Us_pint_acreToMl_acre(double input)
		{
			return input * 473.176;
		}
		public double Us_pint_acreToUs_fl_oz_acre(double input)
		{
			return Us_pint_acreToMl_acre (input) / 29.57;
		}
		public double Us_pint_acreToUs_quart_acre(double input)
		{
			return input * 0.5;
		}
		public double Us_pint_acreToOz_acre(double input)
		{
			return input * 16;
		}
		public double Us_pint_acreToL_ha(double input)
		{
			return Us_pint_acreToL_acre (input) * 2.47105381;
		}
		public double Us_pint_acreToG_ha(double input)
		{
			return Us_pint_acreToL_ha (input) * 0.264172;
		}
		public double Us_pint_acreToMl_ha(double input)
		{
			return Us_pint_acreToL_ha (input) * 1000;
		}

		public double Us_quart_acreToAcres_case(double input){return 0.0;}
		public double Us_quart_acreToL_acre(double input)
		{
			return input * 0.946353;
		}
		public double Us_quart_acreToG_acre(double input)
		{
			return input * 0.25;
		}
		public double Us_quart_acreToMl_acre(double input)
		{
			return input * 946.353;
		}
		public double Us_quart_acreToUs_fl_oz_acre(double input)
		{
			return input * Us_quart_acreToMl_acre(input) / 29.57;
		}
		public double Us_quart_acreToUs_pint_acre(double input)
		{
			return input * 2;
		}
		public double Us_quart_acreToOz_acre(double input)
		{
			return input * 32;
		}
		public double Us_quart_acreToL_ha(double input)
		{
			return Us_quart_acreToL_acre (input) * 2.47105381;
		}
		public double Us_quart_acreToG_ha(double input)
		{
			return Us_quart_acreToL_ha (input) * 0.264172;
		}
		public double Us_quart_acreToMl_ha(double input)
		{
			return Us_quart_acreToL_ha (input) * 1000;
		}

		public double Oz_acreToAcres_case(double input){return 0.0;}
		public double Oz_acreToL_acre(double input)
		{
			return input * 0.0295735;
		}
		public double Oz_acreToG_acre(double input)
		{
			return input * 0.0078125;
		}
		public double Oz_acreToMl_acre(double input)
		{
			return input * 29.5735;
		}
		public double Oz_acreToUs_fl_oz_acre(double input)
		{
			return Oz_acreToMl_acre (input) / 29.57;
		}
		public double Oz_acreToUs_pint_acre(double input)
		{
			return input * 0.0625;
		}
		public double Oz_acreToUs_quart_acre(double input)
		{
			return input * 0.03125;
		}
		public double Oz_acreToL_ha(double input)
		{
			return Oz_acreToL_acre(input)* 2.47105381;
		}
		public double Oz_acreToG_ha(double input)
		{
			return Oz_acreToL_acre(input)* 0.264172;
		}
		public double Oz_acreToMl_ha(double input)
		{
			return Oz_acreToL_acre(input)* 1000;
		}

		public double L_haToAcres_case(double input){return 0.0;}
		public double L_haToL_acre(double input)
		{
			return input * 0.404685642;
		}
		public double L_haToG_acre(double input)
		{
			return L_haToL_acre (input) * 0.264172;
		}
		public double L_haToMl_acre(double input)
		{
			return L_haToL_acre (input) * 1000;
		}
		public double L_haToUs_fl_oz_acre(double input)
		{
			return L_haToMl_acre (input) / 29.57;
		}
		public double L_haToUs_pint_acre(double input)
		{
			return L_haToL_acre (input) * 2.11338;
		}
		public double L_haToUs_quart_acre(double input)
		{
			return L_haToL_acre (input) * 1.05669;
		}
		public double L_haToOz_acre(double input)
		{
			return L_haToL_acre (input) * 33.814;
		}
		public double L_haToG_ha(double input)
		{
			return input * 0.264172;
		}
		public double L_haToMl_ha(double input)
		{
			return input * 1000;
		}

		public double G_haToAcres_case(double input){return 0.0;}
		public double G_haToL_acre(double input)
		{
			return G_haToL_ha (input) * 0.404685642;
		}
		public double G_haToG_acre(double input)
		{
			return input * 0.404685642;
		}
		public double G_haToMl_acre(double input)
		{
			return G_haToMl_ha (input) * 0.404685642;
		}
		public double G_haToUs_fl_oz_acre(double input)
		{
			return G_haToMl_acre (input) / 29.57;
		}
		public double G_haToUs_pint_acre(double input)
		{
			return G_haToL_acre (input) * 2.11338;
		}
		public double G_haToUs_quart_acre(double input)
		{
			return G_haToL_acre (input) * 1.05669;
		}
		public double G_haToOz_acre(double input)
		{
			return G_haToL_acre (input) * 33.814;
		}
		public double G_haToL_ha(double input)
		{
			return input * 3.78541178;
		}
		public double G_haToMl_ha(double input)
		{
			return input * 3785.41178;
		}

		public double Ml_haToAcres_case(double input){return 0.0;}
		public double Ml_haToL_acre(double input)
		{
			return Ml_haToL_ha (input) * 0.404685642;
		}
		public double Ml_haToG_acre(double input)
		{
			return Ml_haToL_acre (input) * 0.264172;
		}
		public double Ml_haToMl_acre(double input)
		{
			return Ml_haToL_acre (input) * 1000;
		}
		public double Ml_haToUs_fl_oz_acre(double input)
		{
			return Ml_haToMl_acre (input) / 29.57;
		}
		public double Ml_haToUs_pint_acre(double input)
		{
			return Ml_haToL_acre (input) * 2.11338;
		}
		public double Ml_haToUs_quart_acre(double input)
		{
			return Ml_haToL_acre (input) * 1.05669;
		}
		public double Ml_haToOz_acre(double input)
		{
			return Ml_haToL_acre (input) * 33.814;
		}
		public double Ml_haToL_ha(double input)
		{
			return input * 0.001;
		}
		public double Ml_haToG_ha(double input)
		{
			return input * 0.000264172052;
		}

		public double V_vToL_acre(double input){ return 0.0;}
		public double V_vToMl_acre(double input){ return 0.0;}
		public double V_vToUs_fl_oz_acre(double input){ return 0.0;}
		public double V_vToQuart_acre(double input){ return 0.0;}

		public double Us_galToImp_gal(double input)
		{
			return input * 0.8337;
		}
		public double Us_galToL(double input)
		{
			return input * 3.785;
		}

		public double LToImp_gal(double input)
		{
			return input/4.54;
		}
		public double LToUs_gal(double input)
		{
			return input * 0.264172;
		}
		public double Imp_galToL(double input)
		{
			return input * 4.54;
		}
		public double Imp_galToUs_gal(double input)
		{
			return input * 1.20094992043;
		}
		public double AcresToHa (double input)
		{
			return input * 0.404686;
		}
		public double HaToAcres (double input)
		{
			return input * 2.47105;
		}

		public double MToFt(double input)
		{
			return input * 3.28084;
		}
		public double FtToM(double input)
		{
			return input * 0.3048;
		}
		public double MileToM(double input)
		{
			return input * 1609.34;
		}
		public double MToMile(double input)
		{
			return input * 0.000621371;
		}

		// Calculation For Results 
		public double NetTankVolume ()
		{
			// Net Tank Fill = Tank Fill - Tank remainder at Fill
			double Result = 0.0;
			switch (HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit)
			{
			case TankCapacityUnit.Imp_gal:
				Result= HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Imp_gal - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Imp_gal;
				break;
			case TankCapacityUnit.L:
				Result= HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.L - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.L;
				break;
			case TankCapacityUnit.Us_gal:
				Result= HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Us_gal - HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Us_gal;
				break;
			}

			return Result;
		}

		#endregion


		 
	}
}

