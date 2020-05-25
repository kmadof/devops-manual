#!/bin/bash
#
echo "=== docker Images==="
docker images
echo "==== Starut running a jmeter/image ===="
docker run "justb4/jmeter:latest"
echo "==== Finish ===="