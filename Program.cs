// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using POC.LinqBenchmarks;

BenchmarkRunner.Run<LinqBenchmarks>();