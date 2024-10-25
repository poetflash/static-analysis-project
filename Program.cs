using BenchmarkDotNet.Running;
using ConsoleApp1;


internal class Program
{
	static void Main(string[] args)
	{
		//BenchmarkRunner.Run<MyBenchmark>();
		ExecutionTime.Run();
	}
}