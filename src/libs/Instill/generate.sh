dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/instill-ai/protobufs/refs/heads/main/openapi/v2/service.swagger.yaml
autosdk generate openapi.yaml \
  --namespace Instill \
  --clientClassName InstillClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
