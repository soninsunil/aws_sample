# aws_sample
repository for AWS related sample

# Objective - POC with AWS services
- Lambda
- A poc to start with AWS Lambda in dotnet core 6.0
- Build/Deploy the lambda in jenkins pipeline

# dotnet cli to install lambda template
dotnet new -i "Amazon.Lambda.Templates::*"
dotnet new lambda --list

# create new function
dotnet new lambda.EmptyFunction --name BlogFunction --profile default --region us-east-2
