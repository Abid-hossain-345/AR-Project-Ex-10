<h2>Project Title:"Realistic Car Physics Simulation in Unity"</h2>

<h4>Objective:</h4>
To design and implement a functional car controller in Unity using realistic physics, custom user input (keyboard-based), and WheelCollider systems to simulate driving mechanics such as acceleration, steering, and rotation.

<h4>Tools & Technologies Used:</h4>
   
   •	Unity Engine (2021 or later)
   
   •	C# for scripting
   
   •	Rigidbody & WheelColliders for realistic car physics
   
   •	Unity Input System (Old) for handling custom key mappings
   
   •	Blender / Unity ProBuilder (optional for car model or track design)

<h4>Features:</h4>
   1. Keyboard-controlled driving:
      
      •	Press D to move forward
      
      •	Press A to move backward
      
      •	Press W to steer right
      
      •	Press S to steer left
   
   2. Realistic physics using WheelColliders
   3. Visual wheel sync with WheelCollider physics
   4. Center of mass adjustment for better vehicle stability
   5. Modular, clean script structure for easy expansion

<h4>Challenges Faced:</h4>

•	Unity input not responding: Initially, key presses like D, A, W, S were not registering due to input focus or Input System setup.

•	Rigidbody conflict: Naming the variable rigidbody caused confusion due to Unity’s built-in property.

•	Spelling errors: Minor typos like centreOfMass vs centerOfMass caused runtime issues.

•	Car not moving: Diagnosed and resolved by confirming physics setup, input handling, and torque application.

<h4>Outcome:</h4>

A fully functional, physics-based car controller that responds accurately to user input. The project provided hands-on understanding of Unity’s physics engine, the importance of input management, and vehicle behavior simulation.

<h4>Future Improvements:</h4>

•	Add braking and reverse lights.

•	Implement camera follow system.

•	Introduce nitro/boost functionality.

•	Add a gear system or automatic transmission.

•	Build a complete race track.

•	Integrate UI dashboard (speedometer, RPM).

•	Enable mobile touch controls.

•	Upgrade to Unity's New Input System for cross-platform compatibility.

