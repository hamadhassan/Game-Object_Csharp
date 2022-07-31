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
## Domain Model
### Class name
![class](https://user-images.githubusercontent.com/96945594/182033049-0fb7b509-ae0f-4b71-b8f0-1e25040715de.jpg)
### Relations and Constraints
![constrain](https://user-images.githubusercontent.com/96945594/182033051-6bba3b0a-cd49-4450-8b6d-a3a15a064a78.jpg)
### Multiplicity
![multiplicty](https://user-images.githubusercontent.com/96945594/182033045-218ed81a-48d3-4940-835e-b8b4d7a6b1a5.jpg)
### Attributes and Function
#### Business Logic Layer
![bl](https://user-images.githubusercontent.com/96945594/182033060-540ae06e-11f5-4004-9956-2a8aa35d818e.JPG)
#### Data Layer
![dl](https://user-images.githubusercontent.com/96945594/182033062-e3f86b37-3e13-481d-b281-e3ac67b036f2.JPG)
#### User Interfaces Layer
![ul](https://user-images.githubusercontent.com/96945594/182033057-92461da1-eb44-42c6-98bb-6f08ba29cb2b.JPG)
## Sequence Diagram
![SD GameObject](https://user-images.githubusercontent.com/96945594/182033146-679d1021-ac48-42d5-ad99-98760585f339.jpg)

