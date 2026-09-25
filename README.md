# SWE40006 — Software Deployment & Evolution Portfolio

A collection of four practical deployment exercises completed as part of **SWE40006 Software Deployment and Evolution** at Swinburne University of Technology.

This repository contains a small public subset of the wider unit work that we were allowed to keep and share.

The applications themselves are intentionally simple. The purpose of these exercises was not to build complex application logic, but to become familiar with **different ways of packaging, deploying, configuring, scaling and operating software across multiple environments**.

Across the four portfolio tasks, I worked with Windows installers, managed cloud platforms, AWS infrastructure and containers.

## Portfolio Overview

### 1. Windows Packaging & Distribution — WiX / MSI

Built and packaged small C# applications using the WiX Toolset.

The exercise progressed from creating a basic MSI installer to packaging an application with external dependencies, producing a self-contained installer and exploring software distribution through GitHub Releases and WinGet.

Key areas:

- MSI packaging with WiX
- application dependencies and DLL packaging
- installation and uninstallation behaviour
- self-contained installer packaging
- GitHub Releases
- WinGet manifests and package distribution

The main lesson from this task was that deployment is more than copying an executable: the target environment, dependencies, installation structure and distribution mechanism all matter.

---

### 2. Managed Cloud Deployment — Azure App Service

Deployed a small ASP.NET Core application to Azure App Service and explored how application behaviour changes between local development and a managed cloud environment.

The task included:

- deploying an ASP.NET Core application to Azure
- environment-specific application configuration
- App Service lifecycle operations
- application health endpoints
- Azure Log Stream
- Application Insights / runtime monitoring
- deploying and observing a small diagnostic application

A major focus was separating application code from environment-specific configuration and understanding why deployment does not end once an application successfully starts.

---

### 3. Scalable AWS Deployment — EC2, RDS, ALB & Auto Scaling

Started with a basic WordPress deployment on a single EC2 instance and progressively moved toward a more scalable AWS architecture.

The final architecture explored:

- EC2 compute
- Amazon RDS for a shared MariaDB database
- S3 backup and restore
- AMIs and Launch Templates
- Application Load Balancer
- Auto Scaling Groups
- deployment across multiple Availability Zones
- security groups
- CloudWatch monitoring
- SNS notifications
- AWS Systems Manager

This task demonstrated why application state, databases, compute instances, traffic routing and monitoring need to be considered separately when moving from a single-server deployment toward scalable infrastructure.

---

### 4. Containerised Deployment — Docker

Explored container-based deployment using small Flask and Python applications.

The task covered:

- building Docker images with a Dockerfile
- running containers locally
- publishing images to Docker Hub
- pulling and running the same image on another environment
- deploying a containerised application publicly
- runtime configuration using environment variables
- port mapping
- bind mounts for persistent host data
- containerising both web and CLI applications

The key idea was to treat the image as the deployable artifact while keeping environment-specific configuration outside the image.

This allows the same image to move between environments without rebuilding it for every target.

---

## What This Repository Demonstrates

These tasks intentionally use small applications so the application code does not hide the deployment concepts being exercised.

The progression across the portfolio was roughly:

**package software -> deploy to a managed platform -> design scalable infrastructure -> package and deploy software portably using containers**

Some of the concepts explored across the repository include:

- software packaging and dependencies
- target environment differences
- configuration management
- repeatable deployment
- cloud infrastructure
- scalability and availability
- health checks and monitoring
- artifact distribution
- containers and persistent data
- deployment automation

## Scope

This repository represents **four early portfolio exercises from a much larger university unit**.

It is not intended to present the applications themselves as production systems. Their simplicity was deliberate: each task isolated a different deployment approach so that the infrastructure and deployment behaviour could be studied directly.

The wider unit also covered software evolution, deployment planning, CI/CD, Infrastructure as Code, DevOps and DevSecOps.

## Status

**Completed / Archived**

These portfolio tasks are finished and the repository is now kept as a record of the deployment work and concepts explored during the unit.