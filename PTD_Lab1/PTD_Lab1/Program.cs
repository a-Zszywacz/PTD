﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTD_Lab1
{

	class Zad1 {
		float f, phi, fs, time;
		int n;
		float[] x;

		Zad1(float f, float phi, float fs, float time, int n)
		{
			this.f = f;
			this.phi = phi;
			this.fs = fs;
			this.time = time;
			this.n = n;
			x = new float[n];

			for(int i= 0; i < n; i++)
			{

			}

		}

		float xn(float f, int n, float fs, float phi)
		{
			float wynik = (float)(0.7 * Math.Sin(2 * Math.PI * (double)f * (double)n / (double)fs + (double)phi) * n);
			return 1; //TODO: change
		}


	}

	class Program
	{
		static void Main(string[] args)
		{
			
			
		}
	}
}
