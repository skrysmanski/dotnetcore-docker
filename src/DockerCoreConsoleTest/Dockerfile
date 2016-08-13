FROM microsoft/dotnet:1.0.0-core
COPY bin/Debug/netcoreapp1.0/ /app/
WORKDIR /app
ENTRYPOINT ["dotnet", "DockerCoreConsoleTest.dll"]