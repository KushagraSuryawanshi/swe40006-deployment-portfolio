# Portfolio 2 — Azure App Service Deployment

## Overview

This task explored deploying and operating a small web application using Azure App Service.

The focus moved away from desktop installation and toward deploying software into a managed cloud platform where configuration, runtime health and monitoring become part of the deployment process.

## What I Built

The task included:

- running and verifying an ASP.NET Core application locally
- deploying the application to Azure App Service
- customising the application to expose deployment/environment information
- starting and stopping the deployed App Service
- moving environment-specific configuration outside the application code
- using Azure application settings for runtime configuration
- adding a health endpoint
- verifying HTTP health responses
- enabling and inspecting application logs through Azure Log Stream
- using Application Insights for additional monitoring
- deploying a small diagnostic application to observe the cloud environment

## What This Demonstrated

An application that works locally may behave differently after deployment because the target environment is different.

Environment-specific values should therefore not be hard-coded into the application. The same build should be capable of running in multiple environments while configuration is supplied by the environment itself.

The task also demonstrated that successful deployment does not guarantee continued application health. Logging, health checks and monitoring are required after deployment to understand how the application behaves when running.

## Key Takeaways

- keep environment-specific configuration outside application code
- use the same application artifact across environments where possible
- deployment success and runtime health are different concerns
- health endpoints give infrastructure a simple way to determine application health
- logs and telemetry become essential once the application is running remotely
- managed platforms remove some infrastructure work but do not remove operational responsibility

## Scope

The web application was deliberately small so the task could focus on configuration, deployment and observability rather than application development.