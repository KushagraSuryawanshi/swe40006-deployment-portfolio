# Portfolio 3 — Scalable AWS Deployment

## Overview

This task started with a basic WordPress deployment on a single EC2 instance and progressively separated the application, database, storage, traffic routing and monitoring responsibilities.

The goal was to understand how a simple deployment evolves when availability, repeatability and scalability become requirements.

## What I Built

The task progressed through:

- WordPress running on Amazon EC2
- Apache, PHP and MariaDB configuration
- migration of the WordPress database to Amazon RDS MariaDB
- maintaining secure database transport
- database backup and restore using Amazon S3
- creating an AMI from the configured application server
- defining EC2 configuration through a Launch Template
- creating an Application Load Balancer
- running multiple EC2 instances behind the load balancer
- configuring an Auto Scaling Group
- distributing instances across multiple Availability Zones
- configuring security-group communication between application servers and RDS
- updating WordPress to use the load balancer address instead of a specific instance
- CloudWatch monitoring
- SNS notifications
- AWS Systems Manager access without exposing normal inbound SSH

## Architecture

Conceptually, the final deployment became:

User Traffic  
→ Application Load Balancer  
→ Auto Scaling Group  
→ EC2 WordPress Instances  
→ Shared Amazon RDS Database

Supporting services included S3 for backup, CloudWatch for monitoring, SNS for notifications and Systems Manager for instance administration.

## What This Demonstrated

A single EC2 instance combines too many responsibilities and creates a single point of failure.

Moving the database to RDS allowed multiple application instances to share persistent state. The Application Load Balancer distributed traffic between healthy instances, while the Auto Scaling Group could maintain or increase compute capacity.

Launch Templates made instance creation repeatable instead of relying on manual server configuration.

## Key Takeaways

- application compute should not own the only copy of persistent database state
- load balancing and auto scaling solve different problems
- a Launch Template defines how new instances should be created
- an Auto Scaling Group controls how many instances should exist
- the load balancer routes traffic only to healthy targets
- security groups should allow only the communication actually required between services
- backups should exist outside the compute instance being protected
- monitoring and alerts are required after deployment because real traffic can reveal failures not found during testing
- administrative access does not always require exposing SSH directly to the internet

## Scope

This was a learning deployment rather than a production WordPress architecture. The infrastructure was deliberately built step-by-step so each responsibility could be understood separately.