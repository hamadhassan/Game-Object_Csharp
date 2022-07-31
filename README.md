# Game Object 
## Case Study Scenario
In this problem, you have to create a class called Point, which models a 2D point with x and y
coordinates.
It contains:

    ● Two instance variables x (int) and y (int).
    ● A default (or "no-argument" or "no-arg") constructor that constructs a point at the default locationof (0, 0).
    ● A parameterized constructor that constructs a point with the given x and y coordinates.
    ● Getter and setter for the instance variables x and y.
    ● A method setXY() to set both x and y.
Next, create a class named Boundary.
It contains:

    ● Four attributes of Point type
        ○ TopLeft
        ○ TopRight
        ○ BottomLeft
        ○ BottomRight
    ● A default (or "no-argument" or "no-arg") constructor that constructs a boundary with default location of TopLeft(0, 0), TopRight(0,90), BottomLeft(90,0) and BottomRight(90,90).
    ● A parameterized constructor that constructs a boundary with the given TopLeft, TopRight,BottomLeft and BottomRight points.
Next, create a class named GameObject.
It contains 4 attributes:

    ● One attribute Shape (2D Array char type).
    ● A StartingPoint (Point type).
    ● A Premises (Boundary type).
    ● A Direction (String type).
