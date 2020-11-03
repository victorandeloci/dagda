<?php

  // Simple RSA Encryption - Decryption

  // ========== INPUT ==========

  $message = $_GET['message'] ?? $_POST['message'];
  if($message) {
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

    $result = [];

    $result['message'] = $message;

    $vars = [];
    $vars['P'] = $p;
    $vars['Q'] = $q;
    $vars['N'] = $n;
    $vars['Z'] = $z;
    $vars['D'] = $d;
    $vars['E'] = $e;

    $result['vars'] = $vars;

    $messageInNumbersData = '';
    foreach ($messageInNumbers as $key => $num)
      $messageInNumbersData .= $num;

    $result['messageInNumbers'] = $messageInNumbersData;

    $cryptedMessageData = '';
    foreach ($cryptedMessage as $crypt)
      $cryptedMessageData .= $crypt;

    $result['cryptedMessage'] = $cryptedMessageData;

    $decryptedMessageData = '';
    $alphabet = range('A', 'Z');
    foreach ($decryptedNumbers as $decrypt)
      $decryptedMessageData .= $alphabet[gmp_intval($decrypt) - 1];

    $result['decryptedMessageData'] = $decryptedMessageData;

    echo json_encode($result);
  }
