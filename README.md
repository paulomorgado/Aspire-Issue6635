# Repro for issue <https://github.com/dotnet/aspire/issues/6635>

1. Select the **Aspire-Issue6635.ApiService** project as the startup project.

![Select Aspire-Issue6635.ApiService project](images/select-apiservice-project.png)

2. Select the **Container (.NET SDK)** profile.

![Select container profile](images/select-container-profile.png)

3. Build the **Aspire-Issue6635.ApiService** project.
4. Select the **Aspire-Issue6635.AppHost** project as the startup project.
5. Start **podman**
6. Run.

Selecting **Wheather** in the **webfrontend** will show telemetry to the Aspire dashboard from the **webfrontend** only:
![dashboard with podman](images/dashboard-podman.jpeg)

When using **docker** where the dashboard shows telemetry from the **apiservice**:
![dashboard with docker](images/dashboard-docker.jpeg)
