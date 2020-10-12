using System;
using System.Collections.Generic;
using System.Text;

namespace Paystack.NetCore.SDK.Fees
{
	public class PaystackFee
	{
		private const double DEFAULT_PERCENTAGE = 0.015;
		private const double DEFAULT_ADDITIONAL_CHARGE = 10000;
		private const double DEFAULT_THRESHOLD = 250000;
		private const double DEFAULT_CAP = 200000;

		double percentage = DEFAULT_PERCENTAGE;
		double additionalCharge = DEFAULT_ADDITIONAL_CHARGE;
		double threshold = DEFAULT_THRESHOLD;
		double cap = DEFAULT_CAP;

		readonly double chargeDivider = 0;
		readonly double crossover = 0;
		readonly double flatlinePlusCharge = 0;
		readonly double flatline = 0;

		public PaystackFee()
		{
			chargeDivider = ChargeDivider();
			crossover = Crossover();
			flatlinePlusCharge = FlatlinePlusCharge();
			flatline = Flatline();
		}

		public void WithPercentage(double percentage)
		{
			this.percentage = percentage;
		}

		public void WithAdditionalCharge(double additionalCharge)
		{
			this.additionalCharge = additionalCharge;
		}

		public void WithThreshold(double threshold)
		{
			this.threshold = threshold;
		}

		public void WithCap(double cap)
		{
			this.cap = cap;
		}

		private double ChargeDivider() => 1 - percentage;
		private double Crossover() => (threshold * chargeDivider) - additionalCharge;
		private double FlatlinePlusCharge() => (cap - additionalCharge) / percentage;
		private double Flatline() => flatlinePlusCharge - cap;


		public int AddCharge(int amountinkobo)
		{
			double Amountinkobo = double.Parse(amountinkobo.ToString());
			int returnAmount;

			if (Amountinkobo > flatline)
				returnAmount = (int)(Math.Round(Amountinkobo + cap));
			else if (Amountinkobo > crossover)
				returnAmount = (int)(Math.Round((Amountinkobo + additionalCharge) / chargeDivider));
			else
				returnAmount = (int)(Math.Round(Amountinkobo / chargeDivider));


			return returnAmount;
		}
	}
}
