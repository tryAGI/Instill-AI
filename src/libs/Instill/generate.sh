dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/instill-ai/protobufs/main/openapiv2/core/service.swagger.yaml
curl -o openapi.artifact.yaml https://raw.githubusercontent.com/instill-ai/protobufs/main/openapiv2/artifact/service.swagger.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml openapi.artifact.yaml
rm openapi.artifact.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Instill \
  --clientClassName InstillClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations