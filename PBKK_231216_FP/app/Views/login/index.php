<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background: linear-gradient(to right, #FFD700, #87CEEB);
            margin: 0;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        .login-container {
            background-color: #ffffff;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
            border-radius: 8px;
            text-align: center;
        }

        h2 {
            color: #1e272e;
        }

        input {
            width: 100%;
            padding: 10px;
            margin: 8px 0;
            box-sizing: border-box;
            border: 1px solid #ced4da;
            border-radius: 4px;
        }

        button {
            width: 100%;
            padding: 10px;
            background-color: #3498db;
            color: #ffffff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        button:hover {
            background-color: #217dbb;
        }

        .separator {
            margin: 20px 0;
            border: 1px solid #dee2e6;
            background-color: #ced4da;
        }

        .social-buttons {
            display: flex;
            justify-content: space-between;
        }

        .button-link {
            display: inline-block;
            padding: 10px 20px;
            text-decoration: none;
            background-color: #ffffff;
            color: #e74c3c;
            border: 1px solid #e74c3c;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            transition: background-color 0.3s ease;
        }

        .button-link:hover {
            background-color: #e74c3c;
            color: #ffffff;
        }
    </style>
</head>

<body>
    <div class="login-container">
        <h2>Login</h2>
        <form method="post" action="login/masuk">
            <input type="text" name="napeng" placeholder="Nama Pengguna" required>
            <input type="text" name="kasan" placeholder="Kata Sandi" required>
            <button type="submit">Masuk</button>
        </form>
        <div class="separator"></div>
        <div class="social-buttons">
            <a href="<?= $link; ?>" class="button-link">Masuk dengan Google</a>
        </div>
    </div>
</body>

</html>