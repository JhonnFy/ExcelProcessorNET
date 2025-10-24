# ===============================
# Script ultra-optimizado: 179,326 CC únicos
# ===============================

# Carpeta de destino
$carpetaDestino = "C:\Developer\ExcelProcessorNET\OrigenDatos\Generar Nombres\NombresGenerados"
if (!(Test-Path -Path $carpetaDestino)) { New-Item -ItemType Directory -Path $carpetaDestino }

# Archivo de salida
$archivo = "$carpetaDestino\cc_179326.txt"

# Hashset para asegurar unicidad
$ccUnicos = @{}

$i = 1
while ($i -le 179326) {
    # Generar CC único: 8 a 10 dígitos
    $cc = Get-Random -Minimum 10000000 -Maximum 9999999999

    if (-not $ccUnicos.ContainsKey($cc)) {
        $ccUnicos[$cc] = $true
        "$i. $cc" | Out-File -FilePath $archivo -Append -Encoding UTF8
        $i++
    }
}

Write-Output "Archivo generado con 179,326 CC únicos en $archivo"
