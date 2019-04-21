namespace PiperFiltersExample
{
    public class CarFactory : AutomobileFactory
    {
        protected override void Build(ref Automobile c)
        {
            //// Build chassis
            //MoldWeldChassis(c);
            //AddSuspension(c);
            //AddGasTank(c);
            //AddTransmission(c);
            //AddWheels(c);

            //// Add engine
            //AddEngine(c);

            //// Add body and finishings
            //MateBodyToFrame(c);
            //AddBatterySparkPlugs(c);
            //AddTires(c);
            //TopOffFluids(c);

            //// Quality Inspection
            //InspectQuality(c);

            var assemblyLine = new AssemblyLine();
            assemblyLine.Register(new MoldWeldChassis())
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
                        .Register(new AddBatteryElements())
                        .Register(new AddTires())
                        .Register(new TopOffFluids())
                        .Register(new InspectQuality())
                        .Build(c);
        }
    }
}