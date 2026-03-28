#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/instill-ai/protobufs/refs/heads/main/openapi/v2/service.swagger.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/instill-ai/protobufs/refs/heads/main/openapi/v2/service.swagger.yaml
autosdk generate openapi.yaml \
  --namespace Instill \
  --clientClassName InstillClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
