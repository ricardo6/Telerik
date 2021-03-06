﻿namespace ComputerBuildingSystem.Factories
{
    using System;
    using System.Collections.Generic;
    using ComputerBuildingSystem.Contracts;

    public class HpManufacturer : ComputersFactory
    {
        public const int InitialPcRam = 2;
        public const int InitialPcCores = 2;
        public const int InitialPcCpuBits = 32;
        public const bool InitialPcHardDriveInRaid = false;
        public const int InitialPcHardDriveSpace = 500;

        public const int InitialLaptopRam = 4;
        public const int InitialLaptopCores = 2;
        public const int InitialLaptopCpuBits = 64;
        public const bool InitialLaptopHardDriveInRaid = false;
        public const int InitialLaptopHardDriveSpace = 500;

        public const int InitialServerRam = 32;
        public const int InitialServerCores = 4;
        public const int InitialServerCpuBits = 32;
        public const bool InitialServerHardDriveInRaid = true;
        public const int InitialServerHardDriveSpace = 1000;
        public const int InitialServerHardDrivesInRaidCount = 2;

        public override IPlayable CreatePc()
        {
            IRam ram = new Ram(InitialPcRam);
            VideoCardBase videoCard = new ColorfulVideoCard();
            ICpu cpu = new Cpu(InitialPcCores, InitialPcCpuBits, ram, videoCard, new Cpu32BitsSquareNumberFinder());
            IEnumerable<HardDrive> hardDrives = new[] 
                    {
                        new HardDrive(InitialPcHardDriveSpace, InitialPcHardDriveInRaid, 0) 
                    };

            return new Pc(cpu, ram, hardDrives, videoCard);
        }

        public override IChargeable CreateLaptop()
        {
            IRam ram = new Ram(InitialLaptopRam);
            VideoCardBase videoCard = new ColorfulVideoCard();
            ICpu cpu = new Cpu(InitialLaptopCores, InitialLaptopCpuBits, ram, videoCard, new Cpu64BitsSquareNumberFinder());
            IEnumerable<HardDrive> hardDrives = new[]
                    {
                        new HardDrive(InitialLaptopHardDriveSpace, false, 0)
                    };
            var battery = new ComputerBuildingSystem.LaptopBattery();

            return new Laptop(cpu, ram, hardDrives, videoCard, battery);
        }

        public override IProcessable CreateServer()
        {
            IRam ram = new Ram(InitialServerRam);
            VideoCardBase videoCard = new MonochromeVideoCard();
            ICpu cpu = new Cpu(InitialServerCores, InitialServerCpuBits, ram, videoCard, new Cpu32BitsSquareNumberFinder());
            IEnumerable<HardDrive> hardDrives = new List<HardDrive>
                    {
                        new HardDrive(
                            0,
                            InitialServerHardDriveInRaid,
                            InitialServerHardDrivesInRaidCount,
                            new List<HardDrive>
                        {
                            new HardDrive(InitialServerHardDriveSpace, false, 0),
                            new HardDrive(InitialServerHardDriveSpace, false, 0)
                        })
                    };

            return new Server(cpu, ram, hardDrives, videoCard);
        }
    }
}
