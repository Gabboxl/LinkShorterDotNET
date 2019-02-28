#!/bin/bash -e
dotnet restore
dotnet build -c release


eval "$(ssh-agent -s)"
echo -e $private_key > travis_rsa
chmod 600 travis_rsa
ssh-add travis_rsa

git clone git@github.com:Gabboxl/LinkShorterDotnetDLL
cd LinkShorterDotnetDLL
cp ../LinkShorterNET/bin/Release/netstandard2.0/LinkShorterDotNET.dll .
git add -A
git commit -am "$TRAVIS_COMMIT_MESSAGE"
git push origin master
