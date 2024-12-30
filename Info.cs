<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Info - Float Cheat Menu</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      background-color: #000;
      color: #fff;
      text-align: center;
      margin: 0;
      padding: 0;
    }

    .navbar {
      display: flex;
      justify-content: center;
      background-color: #111;
      padding: 20px 0;
      position: sticky;
      top: 0;
      border-bottom: 1px solid #333;
    }

    .nav-button {
      text-decoration: none;
      color: #fff;
      padding: 10px 20px;
      background-color: #222;
      border-radius: 5px;
      font-size: 16px;
      transition: background-color 0.3s ease, transform 0.3s ease;
    }

    .nav-button:hover {
      background-color: #555;
      transform: scale(1.1);
    }

    .content {
      display: flex;
      justify-content: center;
      align-items: center;
      height: 80vh;
    }

    .content h1 {
      font-size: 48px;
    }
  </style>
</head>
<body>
  <header class="navbar">
    <a href="index.html" class="nav-button">Home</a>
  </header>

  <div class="content">
    <h1>Info</h1>
  </div>
</body>
</html>
