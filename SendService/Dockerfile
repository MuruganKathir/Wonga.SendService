#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Wonga.SendService.csproj", ""]
COPY ["../Wonga.Common/Wonga.Common.csproj", "../Wonga.Common/"]
COPY ["../Wonga.SendMessage.Orchestrations.Contracts/Wonga.SendMessage.Orchestrations.Contracts.csproj", "../Wonga.SendMessage.Orchestrations.Contracts/"]
COPY ["../Wonga.SendMessage.Orchestrations/Wonga.SendMessage.Orchestrations.csproj", "../Wonga.SendMessage.Orchestrations/"]
COPY ["../Wonga.SendMessage.Adapters.Contracts/Wonga.SendMessage.Adapters.Contracts.csproj", "../Wonga.SendMessage.Adapters.Contracts/"]
COPY ["../Wonga.SendMessage.Contracts/Wonga.SendMessage.Contracts.csproj", "../Wonga.SendMessage.Contracts/"]
COPY ["../Wonga.SendMessage.Adapters/Wonga.SendMessage.Adapters.csproj", "../Wonga.SendMessage.Adapters/"]
RUN dotnet restore "./Wonga.SendService.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Wonga.SendService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Wonga.SendService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Wonga.SendService.dll"]