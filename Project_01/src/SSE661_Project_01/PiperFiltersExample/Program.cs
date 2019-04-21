using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Mercer.SSE.LogFileTool;

namespace PiperFiltersExample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Log.Initialize();

            var carFactory = new CarFactory();
            var car = carFactory.Create("C-123ABC");
            car.DisplayBuildMetadata();

            var truckFactory = new TruckFactory();
            var truck = truckFactory.Create("T-789XYZ");
            truck.DisplayBuildMetadata();

            Console.ReadKey();
            Log.Close();
        }
    }

    public class AssemblyLine
    {
        private List<IAssemblyLineFilter> _filters = new List<IAssemblyLineFilter>();

        public AssemblyLine Register(IAssemblyLineFilter filter)
        {
            _filters.Add(filter);
            return this;
        }

        public void Build(Automobile a)
        {
            foreach (var filter in _filters)
            {
                filter.Execute(a);
            }
        }
    }

    public interface IAssemblyLineFilter
    {
        void Execute(Automobile a);
    }

    public abstract class AssemblyLineFilter : IAssemblyLineFilter
    {
        public void Execute(Automobile a)
        {
            ExecuteFilterTask(a);
            Success(a);
        }

        protected abstract void ExecuteFilterTask(Automobile a);

        private static void Success(Automobile a)
        {
            a.Metadata.AppendLine("SUCCESS!");
        }
    }

    public class MoldWeldChassis : AssemblyLineFilter
    {
        protected override void ExecuteFilterTask(Automobile a)
        {
            a.Metadata.Append("Molding & welding chassis...");
            //...
        }
    }

public class AddFrontSuspension : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding front suspension...");
        //...
    }
}

public class AddRearSuspension : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding rear suspension...");
        //...
    }
}

public class AddGasTank : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding gas tank...");
        //...
    }
}

public class AddAxles : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding rear axles...");
        //...
    }
}

public class AddDriveShafts : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding drive shafts...");
        //...
    }
}

public class AddGearBoxes : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding gear boxes...");
        //...
    }
}

public class AddSteeringBoxComponents : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding steering box components...");
        //...
    }
}

public class AddWheelDrums : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding wheel drums...");
        //...
    }
}

public class AddBrakes : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding braking system...");
        //...
    }
}

public class MateEngineWithTransmission : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Mating engine with transmission...");
        //...
    }
}

public class AttachRadiator : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Attaching radiator...");
        //...
    }
}

public class MateBodyToFrame : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding body to frame...");
        //...
    }
}

public class AddBatteryElements : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding battery & spark plugs...");
        //...
    }
}

public class AddTires : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Adding tires...");
        //...
    }
}

public class TopOffFluids : AssemblyLineFilter
{
    protected override void ExecuteFilterTask(Automobile a)
    {
        a.Metadata.Append("Topping-off fluids...");
        //...
    }
}

    public class InspectQuality : AssemblyLineFilter
    {
        protected override void ExecuteFilterTask(Automobile a)
        {
            a.Metadata.Append("Inspecting quality...");
            //...
        }
    }

    public class AddTrailerHitch : AssemblyLineFilter
    {
        protected override void ExecuteFilterTask(Automobile a)
        {
            a.Metadata.Append("Adding trailer hitch...");
            //...
        }
    }

    public class MateBedToFrame : AssemblyLineFilter
    {
        protected override void ExecuteFilterTask(Automobile a)
        {
            a.Metadata.Append("Adding bed to frame...");
            //...
        }
    }
}