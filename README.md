# Truemoney Wallet Class
- สำคัญมากๆจำเป็นต้อง

# Variable
- $phone    // เบอร์ทรูมันนี่วอลเลท
- $password // รหัสผ่านทรูมันนี่วอลเลท
- $otp_code // OTP ใน SMS 6 หลัก (ตัวเลข)
- $otp_ref  // OTP ใน SMS REF 4 หลัก (ตัวอักษร)
- $access_token // ได้จาก SubmitLoginOTP

# Example Truemoney Wallet Class
```php
<?php
  require "Truewallet.php";
  $tw = new TrueWalletClass($phone, $password);
  
  print_r($tw->RequestLoginOTP());
  print_r($tw->SubmitLoginOTP($otp_code, $phone, $otp_ref));
  
  $tw->setAccessToken($access_token);
  $data = $tw->GetTransaction();
  foreach ($data["data"]["activities"] as $transfer) {
    $values = $tw->GetTransactionReport($transfer["report_id"]);
    print_r($values);
  }
?>
```

# Example Cronjob Windows
- เเก้ไข Url [ตรงนี้](https://github.com/ekkamon/class-truewallet-php/blob/master/CronjobAPIWallet/Program.cs) บรรทัด: 17
- เเก้ไข Loop Time [ตรงนี้](https://github.com/ekkamon/class-truewallet-php/blob/master/CronjobAPIWallet/Program.cs) บรรทัด: 39 // 1000 = วินาที

#### access_token.php
```php
<?php
  require "Truewallet.php";
  $tw = new TrueWalletClass($phone, $password);
  $tw->setAccessToken($access_token);
  print_r($tw->GetProfile());
?>
```

# Help my Truemoney Wallet Class .-.
- โครง Class ตัวนี้นำมาจาก [likecyber](https://github.com/likecyber)
- Parameters เเละ URL ตัวนี้นำมาจาก [chick4nnn](https://gist.github.com/chick4nnn/0b070c673f7977c42db5fd499055d28f)
- เเนวทางเลี้ยง access_token ตัวนี้นำมาจาก [Manatchai Roengtum](https://www.facebook.com/iceyboy.kung)
