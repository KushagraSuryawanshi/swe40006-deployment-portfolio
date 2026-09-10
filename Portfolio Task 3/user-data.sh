#!/bin/bash
systemctl enable apache2
systemctl start apache2
systemctl disable mariadb
systemctl stop mariadb