using BenchmarkDotNet.Attributes;
using Biblioteca.Strings;

namespace Benchmark_CSharp
{
    public class RunFunctions
    {
        //[Benchmark()]
        public void ConcatStrIgualacion()
        {
            var x = new TestString().ConcatStrIgualacion("test");
        }

        //[Benchmark()]
        public void ConcatStrConStrBdlrAppend()
        {
            var x = new TestString().ConcatStrConStrBdlrAppend("test");
        }
        
        //[Benchmark()]
        public void ConcatStrConcat()
        {
            var x = new TestString().ConcatStrConcat("test");
        }

        //[Benchmark()]
        public void ReplaceFor()
        {
            var x = new TestString().ReplaceFor();
        }

        //[Benchmark()]
        public void ReplaceForeach()
        {
            var x = new TestString().ReplaceForeach();
        }

        //[Benchmark()]
        public void CompareToFor()
        {
            var x = new TestString().CompareToFor("test");
        }

        //[Benchmark()]
        public void CompareToForeach()
        {
            var x = new TestString().CompareToForeach("test");
        }

        //[Benchmark()]
        public void CompareToSTR()
        {
            new TestString().CompareToSTR("test");
        }

        //[Benchmark()]
        public void EqualsSTR()
        {
            new TestString().EqualsSTR("test");
        }

        //[Benchmark()]
        public void IgualdadSTR()
        {
            new TestString().IgualdadSTR("test");
        }
    }
}
