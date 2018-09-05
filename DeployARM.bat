dotnet build
dotnet publish
docker build -f "c:\Develop\git\HackathonModule\Docker\arm\Dockerfile" --build-arg EXE_DIR="./bin/Debug/netcoreapp2.0/publish" -t "timatest.azurecr.io/v2/hackathonmodule:latest" "c:\Develop\git\HackathonModule"
docker push timatest.azurecr.io/v2/hackathonmodule:latest
