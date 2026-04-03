# ❌ Tic-Tac-Toe (XO) Game with Custom Graphics

## 📌 Overview
A professional-grade implementation of the classic Tic-Tac-Toe (XO) game, built as a desktop application using C# and Windows Forms. This project serves as a showcase of core software engineering principles, robust logic design, custom UI rendering using GDI+ graphics, and advanced state management techniques, all aimed at delivering a smooth and interactive user experience.

## 📸 Visual Preview

### 🎮 Initial Game State
The game begins with an intuitive interface, tracking the current turn and game status. Turn is set to Player 1 (X) and status is "In Progress".
<img width="1129" height="620" alt="Initial Load" src="image_0.png" />

### 🏆 Winner Declaration & Game Over
Upon a win condition being met (vertical in this case for Player 1), the winning path is highlighted in green, a MessageBox confirms the end, and the UI dynamically updates to show the winner and lock inputs.
<img width="1112" height="608" alt="Order Success" src="image_1.png" />

## 🚀 Key Features
- **Two-Player Local Multiplayer:** Seamless turn-switching logic for Player 1 (X) and Player 2 (O).
- **Robust Win/Draw Detection:** Advanced algorithms horizontal, vertical, and diagonal win patterns, as well as draw scenarios.
- **Dynamic UI Painting (GDI+):** Grid lines are not static images but are dynamically drawn in the `Form1_Paint` event using a custom `Pen`, demonstrating scalability and professional appearance.
- **Real-Time Game State Feedback:** Instantly updates labels for the current turn, draw status, and winner declaration.
- **Game Interface Locking:** Disables grid buttons upon game completion (Win or Draw), demonstrating professional UI state control and preventing further input.
- **Restart Functionality:** A dedicated button to clear the board, reset all game variables (winner, counts, turn), and start fresh.

## 🧠 Technical Highlights
### 1. Robust Game State Management
Instead of relying on scattered boolean flags, this project utilizes an `enum enWinner` (Player1, Player2, Draw, GameInProgress) encapsulated within a dedicated `struct stGameStatus`. This approach provides a clear, maintainable, and type-safe way to track the entire game's lifecycle and logic, ensuring no invalid states are possible.

### 2. Custom UI Rendering with GDI+
A key engineering highlight is the use of GDI+ within the `Form1_Paint` event. Grid lines are dynamically drawn using a custom `Pen`, showcasing an understanding of low-level graphics processing in Windows applications for cleaner, scalable UIs.

### 3. Modular Code Structure
The game's winner detection logic is abstracted into a clean, generalized `GameValue` method. This generalized logic allows `CheckWinner` to easily test any horizontal, vertical, or diagonal button combination for a win condition, making the codebase easier to debug, extend (e.g., adding an AI), and maintain.

### 4. Efficient Turn Handling
Player turn management is strictly enforced using an `enum enPlayer` (Player1, Player2). The `ChangeImage` method handles turn-switching, dynamic updating of button images, tags, and turn labels, ensuring a perfect synchronization between the UI and underlying game logic.

## 🛠️ Technology Stack
- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Graphics Library:** GDI+ (System.Drawing)

## 🛠️ How to Run Locally
To run this project on your own machine, follow these steps:
1. **Clone the repository:** `git clone https://github.com/boumakelnadir/Tic-Tac-Toe-Game-Project.git`
2. **Open the Solution:** Navigate to the project folder and open the `Tic-Tac-Toe-Game Project.sln` file using **Visual Studio 2022** (or later).
3. **Build & Run:** Ensure `Debug|Any CPU` is selected and press `F5` or click the **Start** button in Visual Studio to build and launch the application.

## 🚀 Future Improvements
- **Implementation of a Shared Event Handler:** Refactor the button click events into a single handler to reduce code duplication and showcase advanced UI development techniques.
- **AI for Single Player Mode:** Implement a computer opponent using basic logic (or Minimax algorithm) for single-player functionality.
- **Improved Visuals & Themes:** Enhance the UI with custom themes, smooth animations, and sound effects.

## 📄 License
This project is licensed under the MIT License - see the `LICENSE` file for details.
