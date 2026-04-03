# ❌ Tic-Tac-Toe Game (Classic XO)

## 📌 Overview
A classic, interactive **Tic-Tac-Toe** game developed using **C#** and **Windows Forms**. This project showcases the implementation of game logic, state management, and custom UI rendering using GDI+ graphics.

## 🚀 Features
- **Two-Player Mode:** Play locally with a friend, with automatic turn-switching between Player 1 and Player 2.
- **Win & Draw Detection:** Advanced logic to check for winners (horizontal, vertical, and diagonal) and detect draw scenarios.
- **Dynamic UI Painting:** Custom grid lines drawn using `System.Drawing` for a clean and professional look.
- **Game State Tracking:** Real-time updates on current turn and game results (Winner name or "Draw" status).
- **Restart Functionality:** A dedicated "Restart Game" feature to reset the board and status without relaunching the app.

## 🛠️ Technologies Used
- **Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Graphics:** GDI+ (System.Drawing)

## 🧠 Technical Highlights
- **Enums & Structs:** Used `enum` for player identification and `struct` for game statistics, ensuring clean and readable code.
- **Event-Driven Logic:** Efficient handling of button clicks and form painting events.
- **Resource Management:** Integration of custom images for game pieces (X and O) within the application resources.
- **Modular Design:** Separation between the game's UI and the logical check for winning patterns.
