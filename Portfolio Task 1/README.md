# Portfolio 1 — Windows Packaging & Distribution with WiX

## Overview

This task explored traditional desktop software deployment by packaging small C# applications as Windows MSI installers using the WiX Toolset.

The application logic was intentionally small. The focus was on understanding what is required to move software from a development environment into a distributable and installable package.

## What I Built

The task progressed through several stages:

- packaged a basic C# application as an MSI
- installed the application into the expected Windows program directory
- verified application execution and clean uninstallation
- created and packaged a small `DeploymentChecker` application
- added external dependencies including Humanizer and Spectre.Console
- explicitly packaged the required DLL dependencies
- produced a self-contained installer with its CAB payload embedded
- published the installer through a GitHub Release
- created and validated WinGet package manifests

## What This Demonstrated

A working executable is not necessarily a deployable application.

The installer must account for the target environment and include everything required for the application to run. Missing dependencies can allow installation to succeed while the application itself fails after launch.

WiX also provided an example of language-based deployment: installer components, files and installation structure are described using WiX declarations, which are then interpreted by the WiX Toolset to generate the MSI.

## Key Takeaways

The most useful lessons from this task were:

- packaging must include runtime dependencies rather than assuming they exist on the target machine
- installation and application execution are separate concerns
- repeatable installers are safer than manually copying application files
- distribution is another part of deployment, not simply an afterthought
- a deployment package should be tested in an environment that does not already contain the developer's dependencies

## Scope

The application itself is intentionally basic. The exercise was focused on Windows packaging and distribution rather than application complexity.