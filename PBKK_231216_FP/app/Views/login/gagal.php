<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Jangan Menerobos</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #1a1a1a;
            color: #ffffff;
            margin: 0;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        .welcome-container {
            text-align: center;
        }

        h1 {
            color: #ff6347; /* Tomato Red */
        }

        a {
            color: #800000;
        }
    </style>
</head>

<body>
    <div class="welcome-container">
        <h1>Jangan menerobos!</h1>
        <a href="<?= base_url('/'); ?>">Keluar</a>
    </div>
</body>

</html>