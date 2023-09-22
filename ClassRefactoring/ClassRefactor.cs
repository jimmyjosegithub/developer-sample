using System;

namespace DeveloperSample.ClassRefactoring
{
    public interface ISwallow
    {
        public double GetAirspeedVelocity();
    }
    public interface ISwallowLoad
    {
        public string Name { get; }
    }
    public class SwallowNone : ISwallowLoad
    {
        public string Name { get; } = "None";
    }
    public class SwallowCoconut : ISwallowLoad
    {
        public string Name { get; } = "Coconut";
    }
    public class SwallowAfrican : ISwallow
    {
        ISwallowLoad _swallowLoad;
        public SwallowAfrican(ISwallowLoad swallowLoad)
        {
            _swallowLoad = swallowLoad;
        }
        public double GetAirspeedVelocity()
        {
            if (_swallowLoad.Name == "None")
            {
                return 22;
            }
            else if (_swallowLoad.Name == "Coconut")
            {
                return 18;
            }
            throw new InvalidOperationException();
        }
    }
    public class SwallowEuropean : ISwallow
    {
        ISwallowLoad _swallowLoad;
        public SwallowEuropean(ISwallowLoad swallowLoad)
        {
            _swallowLoad = swallowLoad;
        }
        public double GetAirspeedVelocity()
        {
            if (_swallowLoad.Name == "None")
            {
                return 20;
            }
            else if (_swallowLoad.Name == "Coconut")
            {
                return 16;
            }
            throw new InvalidOperationException();
        }
    }
}
