# 🎮 XO Game Project (Tic-Tac-Toe)

![Tic Tac Toe Banner](./Tic_Tac_Game/Resources/screenshot.png)

A simple, elegant Tic-Tac-Toe (XO) desktop game built with C# WinForms. This project demonstrates a classic two-player XO game with an intuitive UI, crisp logic, and easy setup — perfect for learning WinForms, C# event-driven programming, and basic game state management.

---

## ✨ Highlights
- ✅ Two-player local Tic-Tac-Toe
- 🎯 Clean, beginner-friendly WinForms UI
- 🧠 Simple and readable C# code (Form1.cs + Designer)
- 🛠️ Includes full Visual Studio solution and project files
- 📂 Well-organized file structure: solution, project, resources, designer files

---

## 📁 Repository Structure
- Tic_Tac_Game/
  - Tic_Tac_Game.sln — Visual Studio solution
  - Tic_Tac_Game.csproj — Project file
  - Program.cs — Application entry point
  - Form1.cs — Game logic and event handlers
  - Form1.Designer.cs — UI components and layout
  - Form1.resx — UI resources
  - App.config — App configuration
  - Properties/ — Project properties
  - Resources/ — Images, icons, screenshots
  - bin/ obj/ — Build artifacts (ignored in source control ideally)

---

## 🧩 What’s Inside / Features
- Responsive 3x3 grid UI for gameplay
- Player X and Player O turns, with visual marks
- Win detection (rows, columns, diagonals)
- Draw detection (board full, no winner)
- Reset / New Game option
- Simple scoreboard (if implemented in UI)
- Clean separation between UI and logic for easy learning & modification

---

## ⚙️ Built With
- C# (WinForms)
- Visual Studio (any edition with .NET desktop development)
- .NET Framework / .NET (WinForms compatible runtime)
- Windows desktop platform

---

## 🚀 Getting Started — Run Locally

Prerequisites
- Windows OS (WinForms desktop app)
- Visual Studio 2017/2019/2022 (or newer) with ".NET desktop development" workload installed
- .NET Framework runtime compatible with the project (open the .sln to see target framework)

Steps
1. Clone the repository
   - git clone https://github.com/Moaaz-git/XO-Game-Project.git
2. Open the solution
   - Open Tic_Tac_Game/Tic_Tac_Game.sln in Visual Studio.
3. Build & Run
   - Build (Ctrl+Shift+B) then Run (F5). The game window should appear.
4. Play!
   - Click on empty cells to place X and O alternately. Use Reset/New Game to restart.

---

## 🎮 How to Play
- Two players take turns (X goes first).
- Click any empty cell to place your mark.
- The first player to make three of their marks in a row (horizontal, vertical, or diagonal) wins.
- If all cells are filled with no winner, the game is a draw.

---

## 📝 Code Overview (quick)
- Program.cs: Application entry point; starts the WinForms loop.
- Form1.cs: Core game logic — handles clicks, alternates turns, checks for win/draw, manages UI updates.
- Form1.Designer.cs: Designer-generated file — UI components, buttons for the 3x3 grid, menus, labels.
- Resources: Icons and images used by the UI (place screenshots or icons here).

---

## 🎨 UI & Assets
- To update the UI images or screenshot used in this README, replace:
  - Tic_Tac_Game/Resources/screenshot.png
- For adding icons, use the Resources.resx or add images to the Resources folder and reference them in the Designer.

---

## 🛠️ Suggested Improvements
- Add an AI single-player mode (Minimax algorithm) for single-player play.
- Persistent scoreboard (save wins/draws to a file or settings).
- Animated transitions and nicer visuals (icons, sounds).
- Unit tests for game logic (separate logic from UI to allow headless testing).
- Internationalization (support multiple languages).

---

## 🤝 Contributing
Contributions are welcome! Here’s how you can help:
1. Fork the repo
2. Create a feature branch: git checkout -b feature/awesome-feature
3. Commit your changes: git commit -m "Add awesome feature"
4. Push to branch: git push origin feature/awesome-feature
5. Open a Pull Request describing your changes

Please keep UI and logic separated where possible, and add tests if you extend the core game logic.

---

## 🐛 Reporting Issues
If you find bugs or have ideas, please open an issue in the repo with:
- Steps to reproduce
- Expected vs actual behavior
- Screenshots (if relevant)
- Environment (Windows version, Visual Studio version)

---

## 📜 License
Choose a license to suit your project. A common choice is the MIT License:

MIT License
© 2025 Moaaz-git

(Replace with your preferred license file in the repository. If you want, I can add a LICENSE file for you — tell me which license to use.)

---

## ✉️ Contact
Author: Moaaz-git  
GitHub: https://github.com/Moaaz-git

---

Thank you for checking out XO Game Project! If you'd like, I can:
- Add a screenshot to the README (if you provide one), or
- Generate a LICENSE file, or
- Create a basic single-player AI implementation and add it as a new branch.

Enjoy building and playing! 🎉
