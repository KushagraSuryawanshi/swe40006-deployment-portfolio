# Portfolio 4 — Docker & Container Deployment

## Overview

This task explored container-based deployment using small Python and Flask applications.

The goal was to understand how an application can be packaged into a repeatable image and then run consistently across different environments.

## What I Built

The task included:

- verifying the Docker runtime with `hello-world`
- creating a Flask application
- writing a Dockerfile
- building a Docker image
- running the container locally
- mapping container and host ports
- publishing the image to Docker Hub
- pulling and running the same image from another environment
- running the application on EC2
- supplying runtime configuration through environment variables
- deploying a containerised application publicly
- running a non-web Python CLI application inside a container
- providing input files using a bind mount
- writing output back to the host filesystem through the bind mount

## What This Demonstrated

The Docker image acts as a deployable artifact.

Instead of rebuilding the application for every environment, the same image can be moved between environments while configuration is supplied at runtime.

Docker Hub acts as an artifact registry where the built image can be stored and retrieved by deployment environments.

The bind-mount exercise also demonstrated that containers can be disposable while important application data remains outside the container.

## Containers vs Virtual Machines

A virtual machine normally contains a complete guest operating system.

Containers share functionality from the host operating system while isolating the application and its runtime environment. This generally makes containers smaller and faster to start than full virtual machines.

## Key Takeaways

- build the application image once and reuse the same artifact
- keep environment-specific configuration outside the image
- container images improve deployment repeatability
- registries such as Docker Hub distribute built artifacts
- containers themselves should not automatically be treated as permanent storage
- bind mounts allow host data to persist independently of the container
- port mapping connects services inside the container to the outside environment

## Scope

The applications were intentionally small so the task could concentrate on container behaviour, deployment portability and runtime configuration.