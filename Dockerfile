FROM public.ecr.aws/lambda/dotnet:3.1
#You can alternately also pull these images from DockerHub amazon/aws-lambda-dotnet:5.0

# Copy function code
COPY publish/* ${LAMBDA_TASK_ROOT}

# Set the CMD to your handler (could also be done as a parameter override outside of the Dockerfile)
CMD [ "MyProject::MyFunction.Function::FunctionHandler" ]

