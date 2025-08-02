using Builder;

RobotBuilder builder = new();

// Build a robot with default parts
Robot robot = builder.Build();

// Print default robot specs
Console.Write(robot.ToString());

// Divider for output clarity
Console.WriteLine("----------------");

// Build a robot with custom parts
Robot customRobot = builder
    .SetHead("Brainiac 3000")
    .SetArms("Rocket Punch M90")
    .SetLegs("X-11 Hover Boots")
    .Build();

// Print custom robot specs
Console.Write(customRobot.ToString());
