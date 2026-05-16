# Build and run Gym Management System (.NET Framework WinForms)
$ErrorActionPreference = "Stop"
$projectRoot = $PSScriptRoot
$csproj = Join-Path $projectRoot "GymManagementSystem\GymManagementSystem.csproj"
$exe = Join-Path $projectRoot "GymManagementSystem\bin\Debug\net472\GymManagementSystem.exe"

$running = Get-Process -Name "GymManagementSystem" -ErrorAction SilentlyContinue
if ($running) {
    Write-Host "Closing running Gym Management System..." -ForegroundColor Yellow
    $running | Stop-Process -Force
    Start-Sleep -Seconds 1
}

Write-Host "Building..." -ForegroundColor Cyan
dotnet build $csproj -c Debug
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }

if (-not (Test-Path $exe)) {
    Write-Error "Executable not found: $exe"
}

Write-Host "Starting application..." -ForegroundColor Green
Start-Process -FilePath $exe -WorkingDirectory (Split-Path $exe)
