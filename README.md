# 🎮 Obstacle Dodge

A beginner-friendly 3D obstacle navigation game developed in **Unity** using **C#**. This project was created as part of Section 2: *Obstacle Dodge* from the **Complete C# Unity Game Developer 3D** course by GameDev.tv.

The primary objective of this project is to introduce the fundamentals of Unity game development, including player movement, collision detection, scripting, and basic level design. Through this project, I gained hands-on experience with Unity's core systems and learned how to create interactive gameplay mechanics using C#.

---

## 📖 Project Overview

Obstacle Dodge is a simple 3D game where the player must navigate through a series of obstacles and reach the destination without colliding with any objects. The project focuses on building a strong foundation in Unity development by introducing essential concepts that are used in almost every game.

The game demonstrates how user input, object movement, collision handling, and game logic work together to create an interactive experience.

---

## 🎯 Learning Objectives

This project was developed to learn and practice:

* Unity Editor fundamentals
* C# programming basics
* Transform manipulation
* Player movement systems
* Collision detection
* Component-based architecture
* GameObject management
* Debugging techniques
* Level design principles
* Frame-rate independent movement
* Writing clean and organized code

---

## ✨ Features

### Player Movement

* Smooth player movement using keyboard controls.
* Frame-rate independent movement using `Time.deltaTime`.
* Responsive navigation in a 3D environment.

### Obstacle System

* Multiple obstacles placed throughout the level.
* Collision detection using Unity's physics system.
* Interaction with environmental objects.

### Basic Game Logic

* Player can successfully complete the course by avoiding obstacles.
* Collision events trigger gameplay responses.
* Foundation for future game mechanics.

### Unity Physics Integration

* Use of Colliders.
* Rigidbody interactions.
* Physics-based collision detection.

---

## 🛠️ Technologies Used

| Technology    | Purpose              |
| ------------- | -------------------- |
| Unity         | Game Engine          |
| C#            | Programming Language |
| Visual Studio | Code Editor          |
| Git           | Version Control      |
| GitHub        | Project Hosting      |

---

## 📂 Project Structure

```text
Assets
├── Scenes
│   └── Main Scene
├── Scripts
│   ├── PlayerController.cs
│   ├── CollisionHandler.cs
│   └── Other Gameplay Scripts
├── Materials
├── Prefabs
└── Settings
```

---

## 🎮 Controls

| Input | Action        |
| ----- | ------------- |
| W     | Move Forward  |
| S     | Move Backward |
| A     | Move Left     |
| D     | Move Right    |

---

## 🧠 Concepts Practiced

### 1. Unity Transform System

Manipulating GameObjects using:

```csharp
transform.Translate();
transform.Rotate();
```

### 2. User Input

Reading keyboard input to control player movement.

```csharp
Input.GetAxis("Horizontal");
Input.GetAxis("Vertical");
```

### 3. Frame Rate Independence

Using `Time.deltaTime` to ensure smooth gameplay across different hardware configurations.

```csharp
movementSpeed * Time.deltaTime
```

### 4. Collision Detection

Handling collisions through Unity's built-in event methods.

```csharp
void OnCollisionEnter(Collision collision)
{
    Debug.Log("Object Hit");
}
```

### 5. Debugging

Using Unity's Console and Debug Logs to identify and resolve issues during development.

---

## 🚀 Getting Started

### Prerequisites

Before running the project, ensure you have:

* Unity Hub installed
* A compatible version of Unity
* Visual Studio or another C# IDE

### Installation

1. Clone the repository:

```bash
git clone https://github.com/your-username/Obstacle-Dodge.git
```

2. Open Unity Hub.

3. Click **Open Project**.

4. Select the cloned project folder.

5. Open the main scene.

6. Press **Play** to start the game.

---

## 📸 Screenshots

### Gameplay

Add screenshots or GIFs of your gameplay here.

Example:

```markdown
![Gameplay Screenshot](Screenshots/gameplay.png)
```

---

## 🔄 Future Improvements

This project serves as a foundation for more advanced game development concepts. Potential improvements include:

* Multiple levels
* Checkpoint system
* Sound effects
* Background music
* Particle effects
* UI system
* Main menu
* Pause menu
* Timer system
* Score tracking
* Difficulty levels
* Collectibles
* Animations
* Improved visual design

---

## 📚 What I Learned

During the development of this project, I learned how to:

* Navigate and use the Unity Editor efficiently.
* Write and organize C# scripts.
* Handle player input.
* Detect and respond to collisions.
* Work with Unity's component-based architecture.
* Implement basic gameplay mechanics.
* Debug common programming and Unity-related issues.
* Use Git and GitHub for version control and project management.

This project marks an important milestone in my game development journey and serves as my first step toward creating more complex and feature-rich games.

---

## 👨‍💻 Author

**Abhilash Balabadra**

Computer Science and Engineering Student
SRM Institute of Science and Technology

Aspiring Game Developer passionate about creating interactive experiences using Unity, Unreal Engine, and C#.

---

## ⭐ Acknowledgements

* GameDev.tv
* Complete C# Unity Game Developer 3D Course
* Unity Technologies
* Open-source game development community

---

### If you found this project interesting, feel free to star the repository and follow my game development journey.
