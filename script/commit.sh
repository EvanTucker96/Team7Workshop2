#!/bin/bash

echo "What is your commit message?"

read message

git add *
git commit -m "$message"
git push