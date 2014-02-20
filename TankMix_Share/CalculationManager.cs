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

		double CasesToL(double input);
		double CasesToMl(double input);
		double CasesToG(double input);
		double CasesToUs_fl_oz(double input);
		double CasesToOz(double input);

		double LToCases(double input);
		double LToMl(double input);
		double LToG(double input);
		double LToUs_fl_oz(double input);
		double LToOz(double input);

		double MlToCases(double input);
		double MlToL(double input);
		double MlToG(double input);
		double MlToUs_fl_oz(double input);
		double MlToOz(double input);

		double GToCases(double input);
		double GToL(double input);
		double GToMl(double input);
		double GToUs_fl_oz(double input);
		double GToOz(double input);

		double Us_fl_ozToCases(double input);
		double Us_fl_ozToL(double input);
		double Us_fl_ozToMl(double input);
		double Us_fl_ozToG(double input);
		double Us_fl_ozToOz(double input);

		double OzToCases(double input);
		double OzToL(double input);
		double OzToMl(double input);
		double OzToG(double input);
		double OzToUs_fl_oz(double input);

		double Us_pintToL(double input);
		double Us_quarttToL(double input);

		// Calculation For Results
		double AreaTreatedByTank();
		double WaterAdded ();
		double ProductAmount (AreaTreatedByTank atbt);
		double AdjuvantAmount(AreaTreatedByTank atbt);
		double TotalWater();
		double NumberOfTankNeeded(TotalWater tw);
		double AreaPerRound();
		double RoundsPerTank(AreaPerRound areaPerRound);

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

		public double CasesToL(double input)
		{
			return input * 8.517176505;
		}
		public double CasesToMl(double input)
		{
			return input * 8517.176505;
		}
		public double CasesToG(double input)
		{
			return CasesToMl (input) * 3.78541;
		}
		public double CasesToUs_fl_oz(double input)
		{
			return CasesToMl (input) / 29.57;
		}
		public double CasesToOz(double input)
		{
			return CasesToG(input) / 28.35;
		}

		public double LToCases(double input)
		{
			return input / 8.517176505;
		}
		public double LToMl(double input)
		{
			return input * 1000;
		}
		public double LToG(double input)
		{
			return input * 0.264172;
		}
		public double LToUs_fl_oz(double input)
		{
			return input * 1000 / 29.57;
		}
		public double LToOz(double input)
		{
			return input * 33.814;
		}

		public double MlToCases(double input)
		{
			return LToCases (input) * 1000;
		}
		public double MlToL(double input)
		{
			return input * 0.001;
		}
		public double MlToG(double input)
		{
			return input * 0.000264172;
		}
		public double MlToUs_fl_oz(double input)
		{
			return input / 29.57;
		}
		public double MlToOz(double input)
		{
			return MlToG (input) / 28.35;
		}
		public double GToCases(double input)
		{
			return GToMl(input) /8517.176505;
		}
		public double GToL(double input)
		{
			return input * 3.78541;
		}
		public double GToMl(double input)
		{
			return input * 3785.41;
		}
		public double GToUs_fl_oz(double input)
		{
			return GToMl (input) / 29.57;
		}
		public double GToOz(double input)
		{
			return input / 28.35;
		}
		public double Us_fl_ozToCases(double input)
		{
			return MlToCases (Us_fl_ozToMl (input));
		}
		public double Us_fl_ozToL(double input)
		{
			return Us_fl_ozToMl (input) * 0.001;
		}
		public double Us_fl_ozToMl(double input)
		{
			return input * 29.57;
		}
		public double Us_fl_ozToG(double input)
		{
			return MlToOz (Us_fl_ozToMl (input));
		}
		public double Us_fl_ozToOz(double input)
		{
			return MlToOz (Us_fl_ozToMl (input));
		}

		public double OzToCases(double input)
		{
			return GToCases (OzToG(input));
		}
		public double OzToL(double input)
		{
			return GToL (OzToG(input));
		}
		public double OzToMl(double input)
		{
			return GToMl (OzToG(input));
		}
		public double OzToG(double input)
		{
			return input * 28.35;
		}
		public double OzToUs_fl_oz(double input)
		{
			return GToUs_fl_oz (OzToG(input));
		}
		public double Us_pintToL(double input)
		{
			return input * 0.473176;
		}

		public double Us_quarttToL(double input)
		{
			return input * 0.946353;
		}

		public double WaterAdded ()
		{
			// result = tank capacity - tank remainder at fill
			double tankCapacity = 0.0;
			double tankRemainder = 0.0;
			var tankCapacity_U = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit;
			switch (tankCapacity_U) {
			case TankCapacityUnit.Imp_gal:
				tankCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Imp_gal;
				tankRemainder = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Imp_gal;
				break;
			case TankCapacityUnit.L:
				tankCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.L;
				tankRemainder = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.L;
				break;
			case TankCapacityUnit.Us_gal:
				tankCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Us_gal;
				tankRemainder = HistoryManager.SharedInstance.GetCurrentTankData ().tankremainder_value.Us_gal;
				break;
			}
			return tankCapacity - tankRemainder;
		}

		public double AreaTreatedByTank()
		{
			// result = water added / application volume
			var waterAdded = WaterAdded ();
			double applicationVolume = 0.0;
			var tankCapacity_U = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit;
			switch (tankCapacity_U) {
			case TankCapacityUnit.Imp_gal:
				applicationVolume = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Imp_gpa;
				break;
			case TankCapacityUnit.L:
				applicationVolume = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.L_ha;
				break;
			case TankCapacityUnit.Us_gal:
				applicationVolume = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;
				break;
			}
			return waterAdded / applicationVolume;
		}

		public double ProductAmount (AreaTreatedByTank atbt)
		{
			// result = product rate * Area Treated by Tank
			var result = 0.0;
			switch(HistoryManager.SharedInstance.GetCurrentTankData().productrate_value.unit)
			{
			case ProductRateUnit.Acres_case:
				result = atbt.Acres / HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Acres_case ;
				break;
			case ProductRateUnit.G_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.G_acre * atbt.Acres;
				break;
			case ProductRateUnit.G_ha:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.G_ha * atbt.Ha;
				break;
			case ProductRateUnit.L_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.L_acre * atbt.Acres;
				break;
			case ProductRateUnit.L_ha:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.L_ha * atbt.Ha;
				break;
			case ProductRateUnit.Ml_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Ml_acre * atbt.Acres;
				break;
			case ProductRateUnit.Ml_ha:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Ml_ha * atbt.Ha;
				break;
			case ProductRateUnit.Oz_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Oz_acre * atbt.Acres;
				break;
			case ProductRateUnit.Us_fl_oz_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Us_fl_oz_acre * atbt.Acres;
				break;
			case ProductRateUnit.Us_pint_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Us_pint_acre * atbt.Acres;
				break;
			case ProductRateUnit.Us_quart_acre:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().productrate_value.Us_quart_acre * atbt.Acres;
				break;
			}
			return result;

		}

		public double AdjuvantAmount(AreaTreatedByTank atbt)
		{
			// result = adjuvant rate * area treated by tank
			// if %v/v  adjuvant rate / 100 * area treated by tank
			var result = 0.0;
			var waterAdded_L = 0.0;
			if (HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.unit == AdjuvantRateUnit.V_v) {
				//result = HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.value / 100 * // water add object;
				switch (HistoryManager.SharedInstance.GetCurrentTankData().tankcapacity_value.unit)
				{
				case TankCapacityUnit.L:
					waterAdded_L = WaterAdded ();
					break;
				case TankCapacityUnit.Imp_gal:
					var waterAdded_Imp_gal = WaterAdded ();
					waterAdded_L = Imp_galToL (waterAdded_Imp_gal);
					break;
				case TankCapacityUnit.Us_gal:
					var waterAdded_Us_gal = WaterAdded ();
					waterAdded_L = Us_galToL (waterAdded_Us_gal);
					break;
				}
				result = HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.value / 100 * waterAdded_L;

			} else 
			{
				result = HistoryManager.SharedInstance.GetCurrentTankData ().adjuvantrate_value.value * atbt.Acres;
			}

			return result;
		}

		public double TotalWater()
		{
			// result = field area * application volume + sum capacity
			var result = 0.0;
			switch(HistoryManager.SharedInstance.GetCurrentTankData().applicationvolume_value.unit)
			{
			case ApplicationVolumeUnit.Imp_gpa:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Imp_gpa * HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.Acres + HistoryManager.SharedInstance.GetCurrentTankData ().sumpcapacity_value.Imp_gal;
				break;
			case ApplicationVolumeUnit.L_ha:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.L_ha * HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.Ha + HistoryManager.SharedInstance.GetCurrentTankData ().sumpcapacity_value.L;
				break;
			case ApplicationVolumeUnit.Us_gpa:
				result = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa * HistoryManager.SharedInstance.GetCurrentTankData ().totalarea_value.Acres + HistoryManager.SharedInstance.GetCurrentTankData ().sumpcapacity_value.Us_gal;
				break;
			}
			return result;
		}

		public double NumberOfTankNeeded(TotalWater tw)
		{
			//result = total water / water add
			double tc_L = 0.0;
			double tc_Imp_gal = 0.0;
			double tc_Us_gal = 0.0;
			double result = 0.0;

			switch(HistoryManager.SharedInstance.GetCurrentTankData().tankcapacity_value.unit)
			{
			case TankCapacityUnit.Imp_gal:
				tc_Imp_gal = WaterAdded ();
				tc_L = CalculationManager.sharedInstance.Imp_galToL (tc_Imp_gal);
				tc_Us_gal = CalculationManager.sharedInstance.Imp_galToUs_gal (tc_Imp_gal);
				break;
			case TankCapacityUnit.L:
				tc_L = WaterAdded ();
				tc_Imp_gal = CalculationManager.sharedInstance.LToImp_gal (tc_L);
				tc_Us_gal = CalculationManager.sharedInstance.LToUs_gal (tc_L);
				break;
			case TankCapacityUnit.Us_gal:
				tc_Us_gal = WaterAdded ();
				tc_L = CalculationManager.sharedInstance.Us_galToL (tc_Us_gal);
				tc_Imp_gal = CalculationManager.sharedInstance.Us_galToImp_gal (tc_Us_gal);
				break;
			}

			switch(tw.unit)
			{
			case TotalWaterUnit.Imp_gal:
				result = tw.Imp_gal / tc_Imp_gal;
				break;
			case TotalWaterUnit.L:
				result = tw.L / tc_L;
				break;
			case TotalWaterUnit.Us_gal:
				result = tw.Us_gal / tc_Us_gal;
				break;
			}

			return result;
		}

		public double AreaPerRound()
		{
			// result = boom width  * (field length  - ( total number of headland swaths * boom width)) * 0.0001 *2
			var b = HistoryManager.SharedInstance.GetCurrentTankData ().boomwidth_value.M;
			var c = (HistoryManager.SharedInstance.GetCurrentTankData ().swathlength_value.M - (HistoryManager.SharedInstance.GetCurrentTankData ().number_headlands_swaths_value * HistoryManager.SharedInstance.GetCurrentTankData ().boomwidth_value.M));
			return b * c * 0.0001 * 2;
		}

		public double RoundsPerTank(AreaPerRound areaPerRound)
		{
			double tankCapacity = 0.0;
			double sumpCapacity = 0.0;
			double applicationVolume = 0.0;
			double result = 0.0;
			double waterAdded_L = 0.0;
			switch(HistoryManager.SharedInstance.GetCurrentTankData().applicationvolume_value.unit)
			{
			case ApplicationVolumeUnit.Imp_gpa:
				// result = (tank capacity -sump capacity) / (area per round * application volume)
				tankCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Imp_gal;
				sumpCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().sumpcapacity_value.Imp_gal;
				applicationVolume = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Imp_gpa;
				result = (tankCapacity - sumpCapacity) / (areaPerRound.Acres * applicationVolume);
				break;
			case ApplicationVolumeUnit.L_ha:
				// result = (water added) / (area per round * application volume)
				switch (HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.unit) {
				case TankCapacityUnit.Imp_gal:
					var waterAdded_Imp_gal = WaterAdded ();
					waterAdded_L = Imp_galToL (waterAdded_Imp_gal);
					break;
				case TankCapacityUnit.L:
					waterAdded_L = WaterAdded ();
					break;
				case TankCapacityUnit.Us_gal:
					var waterAdded_Us_gal = WaterAdded ();
					waterAdded_L = Us_galToL (waterAdded_Us_gal);
					break;
				}
				applicationVolume = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.L_ha;
				result = waterAdded_L / (areaPerRound.Ha * applicationVolume);
				break;
			case ApplicationVolumeUnit.Us_gpa:
				// result = (tank capacity -sump capacity) / (area per round * application volume)
				tankCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().tankcapacity_value.Us_gal;
				sumpCapacity = HistoryManager.SharedInstance.GetCurrentTankData ().sumpcapacity_value.Us_gal;
				applicationVolume = HistoryManager.SharedInstance.GetCurrentTankData ().applicationvolume_value.Us_gpa;
				result = (tankCapacity - sumpCapacity) / (areaPerRound.Acres * applicationVolume);
				break;
			}
			return result;
		}
		#endregion


		 
	}
}

