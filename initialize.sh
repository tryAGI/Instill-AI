dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Instill \
  InstillClient \
  https://raw.githubusercontent.com/api/openapi.json \
  tryAGI \
  --output .
