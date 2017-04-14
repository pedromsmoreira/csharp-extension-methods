#!/usr/bin/env bash
echo ""
echo "Restoring Test Project"
	dotnet restore ./tests/Common.Extensions.Tests/Common.Extensions.Tests.csproj
echo ""
echo ""
echo "Run tests..."
echo ""

for test in ./tests/*/
do
    echo "Testing $test"
    pushd "$test"
    dotnet test --framework netcoreapp1.0
    popd
done