# ❌ Tic-Tac-Toe (XO) Game with Custom Graphics

## 📌 Overview
A professional-grade desktop application of the classic Tic-Tac-Toe game, built using C# and Windows Forms. This project goes beyond basic implementation, serving as a showcase for robust game logic design, clean code architecture, GDI+ custom rendering, and sophisticated state management techniques.

## 📸 Visual Preview

### 🎮 Initial Game State
The game initializes with a clean interface, automatically tracking the first player's turn (X) and the game's "In Progress" status.
<img width="800" alt="Initial State" src="TicTacToe-Game-Program-images/image_0.png" />

### 🏆 Win Conditions & User Feedback
Upon a win (shown vertical for Player 1), the winning path is highlighted, a confirmation MessageBox appears, and the game state updates to "Winner: Player 1".
<img width="800" alt="Order Success" src="TicTacToe-Game-Program-images/image_1.png" />

## 🛠️ Technology Stack
- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Graphics Library:** GDI+ (System.Drawing)

## 🚀 Key Features
- **Two-Player Local Multiplayer:** Seamless turn-switching logic between Player 1 (X) and Player 2 (O).
- **Advanced Win/Draw Detection:** Algorithms horizontally, vertically, diagonally, and draw scenarios.
- **Dynamic Grid Painting:** Grid lines are dynamically rendered in the `Form1_Paint` event using custom `Pen` objects, showcasing programmatic UI control.
- **Real-Time State Management:** Instantly updates labels for current turn, win conditions, and draw status.
- **UI State Control:** Disables grid buttons upon game completion to prevent invalid inputs.
- **Restart System:** A dedicated function to clear the board, reset counts, winner flags, and restore initial settings.

## 🧠 Technical Highlights & Engineering Practices

### 1. Robust State Management with Enums & Structs
Instead of using scattered flags, the game utilizes a type-safe `enum enWinner` (Player1, Player2, Draw, GameInProgress) encapsulated within a `struct stGameStatus`. This ensures a predictable, maintainable, and verifiable game lifecycle, preventing invalid states.

### 2. Custom Graphics with GDI+
A major engineering focus is the dynamic drawing of grid lines using GDI+ within the `Form1_Paint` event. This demonstrates an understanding of low-level graphics processing and allows for cleaner, programmatic UI scaling.

### 3. Modular Code Structure
The winner detection logic is abstracted into a generalized `GameValue` method. This modular design makes the logic clear, extensible (e.g., adding AI), and easy to debug.

### 4. Efficient Resource & Event Handling
Uses `enum enPlayer` for turn handling, `Image.FromFile` for dynamic asset loading, and well-organized click event handlers. (Planned refactoring for shared handlers).

## 💡 The Technical Challenges & Solutions
- **Challenge:** Creating a clean way to detect winners without writing redundant code for every possible line combination.
- **Solution:** Designed a generalized method `CheckWinner` that utilizes a shared logical check `GameValue`, reducing code duplication and improving maintainability.

## 🎓 Lessons Learned
- Handling custom painting events in Windows Forms using GDI+.
- Managing predictable application state through the use of strictly typed `Enums` and `Structs`.
- Separation of game logic (winner check) from UI updates.

## 🚀 How to Run locally
To run this project on your machine:
1. **Clone the repository:** `git clone https://github.com/boumakelnadir/Tic-Tac-Toe-Game-Project.git`
2. **Open the Solution:** Navigate to the folder and open `Tic-Tac-Toe-Game Project.sln` in **Visual Studio 2022** (or later).
3. **Build & Run:** Ensure `Debug|Any CPU` is selected, then press `F5` or click **Start** in Visual Studio to launch the application.

## 🔜 Future Improvements
- **Refactoring:** Implement Shared Event Handlers for grid buttons to minimize code duplication.
- **AI Integration:** Add a single-player mode with a simple computer opponent.
- **Visual Enhancements:** Add sound effects and smoother animations.

## 📄 License
This project is licensed under the MIT License - see the `LICENSE` file for details.
