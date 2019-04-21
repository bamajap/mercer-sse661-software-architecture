namespace PiperFiltersExample
{
    public class TruckFactory : AutomobileFactory
    {
        protected override void Build(ref Automobile t)
        {
            //// Build chassis
            //MoldWeldChassis(t);
            //AddTrailerHitch(t);
            //AddSuspension(t);
            //AddGasTank(t);
            //AddTransmission(t);
            //AddWheels(t);

            //// Add engine
            //AddEngine(t);

            //// Add body and finishings
            //MateBodyToFrame(t);
            //AddBatterySparkPlugs(t);
            //AddTires(t);
            //TopOffFluids(t);

            //// Quality Inspection
            //InspectQuality(t);

            var assemblyLine = new AssemblyLine();
            assemblyLine.Register(new MoldWeldChassis())
                        .Register(new AddTrailerHitch())
                        .Register(new AddFrontSuspension())
                        .Register(new AddRearSuspension())
                        .Register(new AddGasTank())
                        .Register(new AddAxles())
                        .Register(new AddDriveShafts())
                        .Register(new AddGearBoxes())
                        .Register(new AddSteeringBoxComponents())
                        .Register(new AddWheelDrums())
                        .Register(new AddBrakes())
                        .Register(new MateEngineWithTransmission())
                        .Register(new AttachRadiator())
                        .Register(new MateBodyToFrame())
                        .Register(new MateBedToFrame())
                        .Register(new AddBatteryElements())
                        .Register(new AddTires())
                        .Register(new TopOffFluids())
                        .Register(new InspectQuality())
                        .Build(t);
        }
    }
}