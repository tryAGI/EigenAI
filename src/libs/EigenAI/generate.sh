#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace EigenAI \
  --clientClassName EigenAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/EigenAI.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/EigenAI.CLI \
  --sdk-project ../../libs/EigenAI/EigenAI.csproj \
  --targetFramework net10.0 \
  --namespace EigenAI \
  --clientClassName EigenAIClient \
  --package-id EigenAI.CLI \
  --tool-command-name eigen-ai \
  --user-secrets-id EigenAI.CLI \
  --api-key-env-var EIGENAI_API_KEY \
  --base-url-env-var EIGENAI_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
