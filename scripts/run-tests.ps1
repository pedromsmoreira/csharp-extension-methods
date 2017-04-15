Get-ChildItem "tests" | ?{ $_.PsIsContainer } | %{
    pushd "tests\$_"
    & dotnet test
    popd
}