FROM jenkins/jenkins:lts

# change to root user
USER root

# install required packages
RUN apt-get update && apt-get install -y \
    sudo \
    apt-utils \
    gnupg2 \
    software-properties-common \
    curl

# download and install .NET SDK
RUN mkdir -p /usr/share/dotnet && \
    curl -fSL -o dotnet-sdk-8.0.302-linux-arm64.tar.gz https://download.visualstudio.microsoft.com/download/pr/ccc923ed-10de-4131-9c65-2a73f51185cb/3c04869af60dc562d81a673b2fb95515/dotnet-sdk-8.0.302-linux-arm64.tar.gz && \
    tar -xzf dotnet-sdk-8.0.302-linux-arm64.tar.gz -C /usr/share/dotnet && \
    rm dotnet-sdk-8.0.302-linux-arm64.tar.gz
ENV PATH="/usr/share/dotnet:${PATH}"
