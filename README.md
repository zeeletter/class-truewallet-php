# Truemoney Wallet Class
โครง Class ตัวนี้นำมาจาก likecyber | Parameters เเละ URL ตัวนี้นำมาจาก chick4nnn

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
- เเก้ไข Url [ตรงนี้](https://github.com/ekkamon/class-truewallet-php/blob/master/CronjobAPIWallet/Program.cs)

# Help my Truemoney Wallet Class .-.
- โครง Class ตัวนี้นำมาจาก [likecyber](https://github.com/likecyber)
- Parameters เเละ URL ตัวนี้นำมาจาก [chick4nnn](https://gist.github.com/chick4nnn/0b070c673f7977c42db5fd499055d28f)
