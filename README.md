# .Net Hello World

This is a sample ASP.Net 8.0 app generated using the .Net SDK `dotnet new blazor` command.

It has then be containerized into a Docker image using [the official documentation](https://learn.microsoft.com/en-us/dotnet/core/docker/build-container).

## Automatic Jobs

### Building

An automatic compilation of the app is started on each push to the repo.

### Publishing

When a git tag is promoted to a Github release, and the release is published, a container image is built and published to the Github container registry.
