using System;
using System.Collections.Generic;

namespace TankMix_Share
{
	public class HistoryManager
	{
		private static Tank currentTankData;
		private static List <CalculationResult> resultList;
		private static HistoryManager sharedInstance;


		private HistoryManager ()
		{
			currentTankData = new Tank();
			resultList = new List<CalculationResult> ();
			InitializeCurrentData ();
		}

		public static HistoryManager SharedInstance
		{
			get
			{
				if(sharedInstance == null)
				{
					sharedInstance = new HistoryManager ();
				}
				return sharedInstance;
			}
		}

		public Tank GetCurrentTankData ()
		{
			return currentTankData;
		}

		public List<CalculationResult> GetResultList()
		{
			return resultList;
		}

		// set default value
		private void InitializeCurrentData()
		{
			currentTankData.adjuvantrate_value.unit = (AdjuvantRateUnit)0;
			currentTankData.adjuvantrate_value.value = 0.0;

			currentTankData.applicationvolume_value.value = 0.0;
			currentTankData.applicationvolume_value.unit = (ApplicationVolumeUnit)0;

			currentTankData.productrate_value.value = 0.0;
			currentTankData.productrate_value.unit = (ProductRateUnit)0;

			currentTankData.tankcapacity_value.value = 0.0;
			currentTankData.tankcapacity_value.unit = (TankCapacityUnit)0;

			currentTankData.tankremainder_value.value = 0.0;
			currentTankData.tankremainder_value.unit = (TankRemainderUnit)0;

			currentTankData.sumpcapacity_value.value = 0.0;
			currentTankData.sumpcapacity_value.unit = (SunpCapacityUnit)0;

			currentTankData.totalarea_value.value = 0.0;
			currentTankData.totalarea_value.unit = (TotalAreaUnit)0;

			currentTankData.boomwidth_value.value = 0.0;
			currentTankData.boomwidth_value.unit = (BoomWidthUnit)0;

			currentTankData.swathlength_value.value = 0.0;
			currentTankData.swathlength_value.unit = (SwathLengthUnit)0;

			currentTankData.number_headlands_swaths_value = 0.0;
		}


	}
}

