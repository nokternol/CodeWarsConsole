using BenchmarkDotNet.Attributes;
using CodeWars.Kata;

namespace CodeWars.Benchmarks 
{
    public class DisemvowelTrollsBenchmarks
    {
        private readonly List<string> randomInputs = new();
        public DisemvowelTrollsBenchmarks()
        {
            var rnd = new Random();
            int RandomInt(int a, int b) => rnd.Next(b - a) + a;
            var chars = "abcdefghijklmnopqrsruvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?!,@#$%^&*()[]{};         ";
            char randomChar() => chars[RandomInt(0, chars.Length)];
            for (var i = 0; i < 100; ++i)
            {
                var str = new string(Enumerable.Range(0, RandomInt(20, 100)).Select(_ => randomChar()).ToArray());
                randomInputs.Add(str);
            }
        }

        [Benchmark]
        public void CurrentSolution()
        {
            randomInputs.ForEach(input => DisemvowelTrolls.Disemvowel(input));
        }
    }
}
