<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Selamat Datang</title>
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

        .welcome-container {
            background-color: #ffffff;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
            border-radius: 8px;
            text-align: center;
        }

        h2 {
            color: #1e272e;
        }

        a {
            color: #34495e;
        }
    </style>
</head>

<body>
    <div class="welcome-container">
        <h2>Selamat datang <?= session()->get('nama_pengguna'); ?></h2>
        <a href="<?= base_url('login/keluar'); ?>">Keluar</a>
    </div>
</body>

</html>