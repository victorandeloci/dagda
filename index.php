<?php

  // Simple RSA Encryption - Decryption

  // ========== INPUT ==========

  $message = $_GET['message'] ?? $_POST['message'];
  $messageInNumbers = [];

  //manipulação da mensagem
  $messageChars = str_split($message);
  foreach ($messageChars as $letter) {
    $messageInNumbers[] = (ord(strtoupper($letter)) - ord('A') + 1);
  }

  $p = 7;
  $q = 5;

  $n = $p * $q;
  $z = ($p - 1) * ($q - 1);

  $d = 0;
  $e = 0;

  //divisores de z
  $base_divs = [];
  for ($i = 1; $i <= $z; $i++)
    if($z % $i == 0)
      $base_divs[] = $i;

  //primo em relação a z randômico
  $possibilities = [];
  for ($i = 1; $i <= $z; $i++) {
    $divs = [];
    for ($x = 1; $x <= $i; $x++)
      if($i % $x == 0)
        $divs[] = $x;

    $counter = 0;
    foreach ($divs as $key)
      if($key != 1 && in_array($key, $base_divs))
        $counter++;

    if($i > 1 && $counter == 0) {
      $possibilities[] = $i;
    }
  }
  $d = $possibilities[array_rand($possibilities)];

  do { $e++; } while (($e * $d) % $z != 1);

  // ========== ENCRYPTION ==========

  $cryptedMessage = [];
  foreach ($messageInNumbers as $num)
    $cryptedMessage[] = gmp_pow($num, $e) % $n;

  // ========== DECRYPTION ==========

  $decryptedNumbers = [];
  foreach ($cryptedMessage as $crypt)
    $decryptedNumbers[] = gmp_pow($crypt, $d) % $n;

  // ========== OUTPUT ==========

  echo '<h1>Variáveis</h1>';

  echo 'P: ' . $p . '<br>';
  echo 'Q: ' . $q . '<br>';
  echo 'N: ' . $n . '<br>';
  echo 'Z: ' . $z . '<br>';
  echo 'D: ' . $d . '<br>';
  echo 'E: ' . $e . '<br>';

  echo '<h3>Mensagem Original:</h3>';

  foreach ($messageInNumbers as $key => $num)
    echo $num . ' => <b>' . $messageChars[$key] . '</b><br>';

  echo '<h3>Mensagem Encriptada:</h3>';

  foreach ($cryptedMessage as $crypt)
    echo $crypt . '<br>';

  echo '<h3>Mensagem Decriptada:</h3>';

  $alphabet = range('A', 'Z');
  foreach ($decryptedNumbers as $decrypt)
    echo $decrypt . ' => <b>' . $alphabet[gmp_intval($decrypt) - 1] . '</b><br>';
