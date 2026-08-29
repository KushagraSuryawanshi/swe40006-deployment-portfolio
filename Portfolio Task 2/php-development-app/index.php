<?php 
$php_version = phpversion();
$date = date("Y-m-d H:i:s");
$environment = getenv("APP_ENV") ?: "Local Development";
$req_method = $_SERVER["REQUEST_METHOD"];
$host = $_SERVER["HTTP_HOST"];


?>
<div>
    <h2>PHP deployment app</h2>
    <ul>
        <li>Runtime: <?= $php_version ?></li>
        <li>Status: Running</li>
        <li>Environment: <?= $environment ?></li>
        <li>Current Server Time: <?= $date ?></li>
        <li>Request Method: <?= $req_method ?> </li>
        <li>Host: <?= $host ?> </li>
    </ul>
</div>