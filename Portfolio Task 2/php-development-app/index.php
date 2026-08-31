<?php 
$php_version = phpversion();
$date = date("Y-m-d H:i:s");
$environment = getenv("APP_ENV") ?: "Local Development";
$req_method = $_SERVER["REQUEST_METHOD"];
$host = $_SERVER["HTTP_HOST"];
$appInsightsConnectionString = getenv("APPLICATIONINSIGHTS_CONNECTION_STRING") ?: "";

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

<script src="https://js.monitor.azure.com/scripts/b/ai.3.gbl.min.js"></script>

<script>
    const appInsights = new Microsoft.ApplicationInsights.ApplicationInsights({
        config: {
            connectionString: <?= json_encode($appInsightsConnectionString) ?>
        }
    });

    appInsights.loadAppInsights();
    appInsights.trackPageView();
</script>