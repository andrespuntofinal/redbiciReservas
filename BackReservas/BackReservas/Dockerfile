FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR servreser

EXPOSE 80
EXPOSE 8085


COPY ./*.csproj ./
RUN dotnet restore 

COPY . .
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/sdk:3.1
WORKDIR /servreser

COPY --from=build /servreser/out .
ENTRYPOINT ["dotnet", "BackReservas.dll"]