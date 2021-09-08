namespace Vectors
{
	using System;

	class Vector
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Vector()
		{

		}

		public Vector(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public double Lenght()
		{
			double result;
			result = Math.Sqrt((X * X) + (Y * Y));
			Math.Round(result, 2);
			return result;
		}

		public static double Angle(Vector v1, Vector v2)
		{
			double result;
			double cos = Cos(v1, v2);
			result = Math.Acos(cos);
			return result;
		}

		public double Angle(Vector vectorTarget)
		{
			double result;
			Vector thisVector = this;
			double cos = Cos(thisVector, vectorTarget);
			result = Math.Acos(cos);
			return result;
		}

		public static double Cos(Vector v1, Vector v2)
		{
			Exception ZeroLengthExeption = new Exception("One of vectors has zero length");
			if(v1.Lenght() + v2.Lenght() <= 0)
				throw ZeroLengthExeption;

			double result;
			result = v1 * v2 / (v1.Lenght() * v2.Lenght());
			return result;
		}

		public double Cos(Vector targetVector)
		{
			Vector thisVector = this;
			Exception ZeroLengthExeption = new Exception("One of vectors has zero length");
			if(thisVector.Lenght() + targetVector.Lenght() <= 0)
				throw ZeroLengthExeption;

			double result;
			double dotProduct = thisVector * targetVector;
			result = dotProduct / (thisVector.Lenght() * targetVector.Lenght());
			return result;
		}

		public static double Sin(Vector v1, Vector v2)
		{
			double result;
			double cos = Cos(v1, v2);
			result = Math.Sqrt(1 - Math.Pow(cos, 2));
			return result;
		}

		public static Vector operator +(Vector v1, Vector v2)
		{
			double resultX = v1.X + v2.X;
			double resultY = v1.Y + v2.Y;
			Vector result = new Vector(resultX, resultY);
			return result;
		}

		public static Vector operator -(Vector v1, Vector v2)
		{
			// Subtraction of two vectors
			double resultX = v1.X - v2.X;
			double resultY = v1.Y - v2.Y;
			Vector result = new Vector(resultX, resultY);
			return result;
		}
		public static double operator *(Vector v1, Vector v2)
		{
			// Dot product of two vectors
			double result;
			result = (v1.X * v2.X) + (v1.Y * v2.Y);
			return result;
		}
	}
}
