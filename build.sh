#!/bin/bash
## DOWNLOAD BINARIES
set -e
PATH=$(pwd)/node_modules/.bin:$PATH
if ! [ -x "$(command -v elm-land)" ]; then
	npm install elm-land@0.20.1
fi

## BUILD
elm-land build

## CLEAN UP, cloudflare pages will reject the node_module size of >25mb
rm -rf node_modules