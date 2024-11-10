namespace PipelineForBuildTest
{
    public class Concatinator
    {
        public T AddorConcat<T>(T? value1, T? value2)
        {
            if(value1 == null)
                throw new ArgumentNullException("Value1 Cannot be Null");
            if(value2 == null)
                throw new ArgumentNullException("Value1 Cannot be Null");
            if (value1.GetType() != value2.GetType())
                throw new ArgumentException("Value1 and Value2 Should be of Same Type");
            dynamic val1 = value1;
            dynamic val2 = value2;
            return val1 + val2;
        }
    }
}
