# Use the base image with SQL Server 2022
FROM mcr.microsoft.com/mssql/server:2022-CU5-ubuntu-20.04

USER root

# Environment variables
ENV ACCEPT_EULA=Y
ENV MSSQL_PID: "Developer"
ENV MSSQL_TCP_PORT=1433
ENV MSSQL_PID=Developer
ENV MSSQL_SA_PASSWORD="BpkEKzs0mI4YMMUCVIt0"      

# Expose the SQL Server port
EXPOSE 1433

# Start SQL Server when the container is run
CMD /opt/mssql/bin/sqlservr
