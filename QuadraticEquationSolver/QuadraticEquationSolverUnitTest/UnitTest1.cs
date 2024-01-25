using NUnit.Framework;
using QuadraticEquationSolver;

namespace QuadraticEquationSolverTests
{
	public class Tests
	{
		[Test]
		public void Test1_PositiveDelta()
		{
			var (x1, x2, hasRealRoots) = QuadraticEquationSolver.QuadraticEquationSolver.Solve(1, -3, 2);
			Assert.IsTrue(hasRealRoots);
			Assert.AreEqual(1, x1, 1);
			Assert.AreEqual(2, x2, 1);
		}

		[Test]
		public void Test2_ZeroDelta()
		{
			var (x1, x2, hasRealRoots) = QuadraticEquationSolver.QuadraticEquationSolver.Solve(1, -2, 1);
			Assert.IsTrue(hasRealRoots);
			Assert.AreEqual(1, x1);
			Assert.AreEqual(x1, x2);
		}

		[Test]
		public void Test3_NegativeDelta()
		{
			var (x1, x2, hasRealRoots) = QuadraticEquationSolver.QuadraticEquationSolver.Solve(1, 2, 3);
			Assert.IsFalse(hasRealRoots);
		}
	}
}